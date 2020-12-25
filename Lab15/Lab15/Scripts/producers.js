var apiBaseUrl = "http://localhost:2313/api/";
var producerssUrl = apiBaseUrl + "producers/";
function reloadproducerList() {
	var producersList = $("#producersList");
	if (producersList.length) { //Есть элемент для списка пользователей - значит мы на главной странице - можно загрузить список
		$.ajax({
			url: producerssUrl,
			dataType: "json",
			data: null,
			type: "GET",
			success: function (data) {
				// Do something with the result
				var itemsCount = data.length;
				producersList.html("");
				var html = "<table>";
				for (var i = 0; i < itemsCount; i++) {
					var item = data[i];
					var id = item.id;
					var firstName = item.FirstName;
					var secondName = item.SecondName;
					var lastName = item.LastName;
					html += "<tr><td>" + lastName + "</td><td>" + firstName + "</td><td>" + secondName + "</td>";
					html += "<td><a href='edit.html?id=" + id + "'>Редактировать</a>&nbsp;<a href='#' class='delete_producer' data-id='" + id + "'>Удалить</a></td></tr>";
				}
				html += "</table>";
				producersList.html(html);
			}
		});
	}
}
$(function () {
	reloadproducerList();
	var producerInfo = $("#producerInfo");
	if (producerInfo.length) { //Есть элемент для информации о пользователе -  загрузить информацию о нём
		var url_string = window.location.href;
		var url = new URL(url_string);
		var id = url.searchParams.get("id");
		if (id != null) {
			$.ajax({
				url: producersUrl + id + "/",
				dataType: "json",
				data: null,
				type: "GET",
				success: function (data) {
					var id = data.id;
					var firstName = data.FirstName;
				
					var lastName = data.LastName;
					$("#LastName").val(lastName);
					$("#FirstName").val(firstName);
			
				}
			});
			producerInfo.after("<input type='button' id='EditProducer' value='Сохранить'/>");
		}
		else {
			producerInfo.after("<input type='button' id='CreateProducer' value='Создать'/>");
		}
	};
	$(document).on("click", "a.delete_producer", function () {
		var id = $(this).attr("data-id");
		if (id != null) {
			$.ajax({
				url: producersUrl + id + "/",
				dataType: "json",
				data: null,
				type: "DELETE",
				success: function (data) {
					reloadproducerList();
				}
			});
		}
	});
	$(document).on("click", "#CreateProducer", function () {
		var producerData = {
			LastName: $("#LastName").val(),
			FirstName: $("#FirstName").val(),
		
		};
		$.ajax({
			url: producersUrl,
			dataType: "json",
			data: producerData,
			type: "POST",
			success: function () {
				window.location.href = "../producers/index.html";
			}
		});
	});
	$(document).on("click", "#EditProducer", function () {
		var url_string = window.location.href;
		var url = new URL(url_string);
		var id = url.searchParams.get("id");
		if (id != null) {
			var producerData = {
				id: id,
				LastName: $("#LastName").val(),
				FirstName: $("#FirstName").val(),
				
			};
			$.ajax({
				url: producerssUrl + id + "/",
				dataType: "json",
				data: producerData,
				type: "PUT",
				success: function () {
					window.location.href = "../producers/index.html";

				}
			});
		}
	});
})
