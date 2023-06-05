<?php
require 'vendor/autoload.php';

use Facebook\WebDriver\Remote\DesiredCapabilities;
use Facebook\WebDriver\Remote\RemoteWebDriver;
use Facebook\WebDriver\WebDriverBy;

// Ustalenie ustawień dla przeglądarki Chrome
$chromeOptions = new \Facebook\WebDriver\Chrome\ChromeOptions();
$chromeOptions->addArguments(['--headless']); // Opcjonalnie: Uruchomienie w trybie headless (bez wyświetlania przeglądarki)

// Inicjalizacja sterownika Chrome WebDriver
$capabilities = DesiredCapabilities::chrome();
$capabilities->setCapability(\Facebook\WebDriver\Chrome\ChromeOptions::CAPABILITY, $chromeOptions);
$driver = RemoteWebDriver::create('http://localhost:4444/wd/hub', $capabilities);

// Nawigacja do strony
$driver->get('https://www.zsk.poznan.pl/plany_lekcji/2023plany/technikum/');

// Poczekaj na załadowanie tabeli
$driver->wait()->until(
	WebDriverExpectedCondition::presenceOfElementLocated(WebDriverBy::className('plany_lekcji'))
);

// Pobierz zawartość tabeli
$table = $driver->findElement(WebDriverBy::className('plany_lekcji'));
$rows = $table->findElements(WebDriverBy::tagName('tr'));

// Wyświetl dane z tabeli
foreach ($rows as $row) {
	$cells = $row->findElements(WebDriverBy::tagName('td'));
	foreach ($cells as $cell) {
		echo $cell->getText() . " ";
	}
	echo "<br>";
}

// Zamknij przeglądarkę
$driver->quit();
