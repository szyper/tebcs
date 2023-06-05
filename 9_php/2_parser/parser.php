<?php
// Tworzenie nowego obiektu DOMDocument
$dom = new DOMDocument();

// Wyłączanie ostrzeżeń przy nieprawidłowej strukturze HTML
libxml_use_internal_errors(true);

// Ładowanie zawartości strony
$dom->loadHTMLFile('http://www.example.com');

// Przeszukiwanie i manipulowanie strukturą HTML
$title = $dom->getElementsByTagName('title')->item(0)->nodeValue;
$paragraphs = $dom->getElementsByTagName('p');

// Wyświetlanie wyników
echo "Tytuł: " . $title . "\n";

foreach ($paragraphs as $paragraph) {
	echo "Paragraf: " . $paragraph->nodeValue . "\n";
}
