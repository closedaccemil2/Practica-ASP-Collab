
// JavaScript code for converting units

var factors1 = new Array(1, 0.01, 0.00001, 0.00000621, 0.3937, 0.0328, 0.01094);
var factors2 = new Array(100, 1, 0.001, 0.000621, 39.37, 3.28,  1.094);
var factors3 = new Array(100000, 1000, 1, 0.621, 39370, 3280, 1094);
var factors4 = new Array(160934, 1609.34, 1.60934, 1, 63360, 5280,1760);
var factors5 = new Array(2.54, 0.0254, 0.0000254, 0.0000158, 1, 0.08333, 0.02778);
var factors6 = new Array(30.48, 0.3048, 0.0003048, 0.0001896, 12, 1, 0.3333);
var factors7 = new Array(91.44, 0.9144, 0.0009144, 0.0005688, 36, 3, 1);
var factors = new Array(factors1,factors2,factors3,factors4,factors5,factors6,factors7);
	
function initConversion() {
	from_index = document.length_con.from_unit.selectedIndex;
	to_index = document.length_con.to_unit.selectedIndex;
	factor = factors[from_index][to_index];
	document.getElementById("formula").innerHTML = document.length_con.from_unit.options[document.length_con.from_unit.selectedIndex].text
		+ " = " + factor + " " + document.length_con.to_unit.options[document.length_con.to_unit.selectedIndex].text;
	if (isNaN(document.length_con.from_value.value)) {
		document.getElementById("to_value").innerHTML = "Not a valid number.";
	}
	else {
		document.getElementById("to_value").innerHTML = factor * document.length_con.from_value.value;
	}
}

function temperatureConverter(valNum) {
	valNum = parseFloat(valNum);
	let val1 = document.getElementById('tempsF').value;
	let val2 = document.getElementById('tempsC').value;
	let val3 = document.getElementById('tempsK').value;
	switch (val1) {
		case "Cel":
			document.getElementById("outputCelcius").innerHTML = (valNum - 32) / 1.8;
			break;
		case "Kel":
			document.getElementById("outputKelvin").innerHTML = ((valNum - 32) / 1.8) + 273.15;
			break;
	}
	switch (val2) {
		case "Far":
			document.getElementById("outputFahrenheit").innerHTML = (valNum * 1.8) + 32;
			break;
		case "Kel":
			document.getElementById("outputKelvin").innerHTML = valNum + 273.15;
			break;
	}
	switch (val3) {
		case "Cel":
			document.getElementById("outputCelcius").innerHTML = valNum - 273.15;
			break;
		case "Far":
			document.getElementById("outputFahrenheit").innerHTML = ((valNum - 273.15) * 1.8) + 32;
			break;
	}
}


function weightConverter(valNum) {
	valNum = parseFloat(valNum);

	let val1 = document.getElementById('massG').value;
	switch (val1) {
		case "Lib":
			document.getElementById("outputPounds").innerHTML = valNum * 0.0022046;
			break;
		case "Kil":
			document.getElementById("outputKilograms").innerHTML = valNum / 1000;
			break;
		case "Onz":
			document.getElementById("outputOunces").innerHTML = valNum * 0.035274;
			break;
	}

	let val2 = document.getElementById('massK').value;
	switch (val2) {
		case "Lib":
			document.getElementById("outputPounds").innerHTML = valNum * 2.2046;
			break;
		case "Gram":
			document.getElementById("outputGrams").innerHTML = valNum * 1000;
			break;
		case "Onz":
			document.getElementById("outputOunces").innerHTML = valNum * 35.274;
			break;
	}

	let val3 = document.getElementById('massO').value;
	switch (val3) {
		case "Lib":
			document.getElementById("outputPounds").innerHTML = valNum * 0.0625;
			break;
		case "Gram":
			document.getElementById("outputGrams").innerHTML = valNum / 0.035274;
			break;
		case "Kil":
			document.getElementById("outputKilograms").innerHTML = valNum / 35.274;
			break;
	}

	let val4 = document.getElementById('massL').value;
	switch (val4) {
		case "Onz":
			document.getElementById("outputOunces").innerHTML = valNum * 16;
			break;
		case "Gram":
			document.getElementById("outputGrams").innerHTML = valNum / 0.0022046;
			break;
		case "Kil":
			document.getElementById("outputKilograms").innerHTML = valNum / 2.2046;
			break;
	}
}

function readableBytes(bytes) {
	var i = Math.floor(Math.log(bytes) / Math.log(1024)),
		sizes = ['B', 'KB', 'MB', 'GB', 'TB', 'PB', 'EB', 'ZB', 'YB'];
	document.getElementById("unitResult").innerHTML = (bytes / Math.pow(1024, i)).toFixed(2) * 1 + ' ' + sizes[i];;
}