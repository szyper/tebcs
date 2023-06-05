<?php
// Tworzenie nowego obiektu DOMDocument
$dom = new DOMDocument();

// Wyłączanie ostrzeżeń przy nieprawidłowej strukturze HTML
libxml_use_internal_errors(true);

// Ładowanie zawartości strony
$dom->loadHTMLFile('https://www.zsk.poznan.pl/plany_lekcji/2023plany/technikum/');

// Przeszukiwanie i manipulowanie strukturą HTML
$title = $dom->getElementsByTagName('title')->item(0)->nodeValue;
$paragraphs = $dom->getElementsByTagName('p');

// Wyświetlanie wyników
echo "Tytuł: " . $title . "<br>";

foreach ($paragraphs as $paragraph) {
	echo "Paragraf: " . $paragraph->nodeValue . "\n";
}
