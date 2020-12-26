var apiBaseUrl = "https://localhost:44334/api/";
var filmsUrl = apiBaseUrl + "Films/";

function LoadFilms(data, filmsList) {


	// Do something with the result
	var itemsCount = data.length;
	filmsList.html("");
	var html = "<table>";

	html += "<thead><tr>";
	html += "		<th scope='col'>Название</th>";
	html += "		<th scope='col'>Год</th>";
	html += "		<th scope='col'>Режисер</th>";
	html += "		<th scope='col'>Постер</th>";

	html += "	</tr></thead>";
	html += "<tbody>";
	for (var i = 0; i < itemsCount; i++) {
		var item = data[i];
		var filmId = item.id;
		var Title = item.Title;
		var Year = item.year;
		var cover = item.cover;
		var Producer = item.Producer1.FullName;

		
		html += "<tr>";
		html += "<td>" + Title + "</td>";
		html += "<td>" + Year + "</td>";
		html += "<td>" + Producer + "</td>";
		html += "<td>" + "<img id='ItemPreview' src='data:image/png;base64,"+cover+"'>"+ "</td>";
		html += "<td><a href='edit.html?id=" + filmId + "'>Редактировать</a>&nbsp;<a href='#' class='delete_film' data-id='" + filmId + "'>Удалить</a></td></tr>";
	}
	html += "</tbody>";
	html += "</table>";
	filmsList.html(html);
}

function reloadFilmsList() {
	var filmsList = $("#FilmsList");
	if (filmsList.length) { //Есть элемент для списка пользователей - значит мы на главной странице - можно загрузить список
		$.ajax({
			url: filmsUrl,
			dataType: "json",
			data: null,
			type: "GET",

			success: function (data) {

				LoadFilms(data, filmsList);
			},
			error: function (xmlHttpRequest, textStatus, errorThrown) {
				if (xmlHttpRequest.readyState == 0 || xmlHttpRequest.status == 0)
					return;  // it's not really an error
				else
					alert("get films failed");
			}
		});

	}
		
}

function loadFilmInfo(){
	var filminfo = $("#FilmInfo");
}

$(document).ready(function () {
	reloadFilmsList();
})