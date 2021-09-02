<?php

   echo ("<html>");
   echo("<head>
           <meta charset='UTF-8'>
           <title>Ispis HTML-a</title>
         </head>");
   echo ("<body>");
   echo ("<div><p>Neki tekst</p></div>");
   echo ("</body>");
   echo ("</html>");
   echo date("Y-m-d, H:i:s ");
   echo "<br>datum na drugi način: ";
   echo date("d.m.Y. ");
echo "<br>";
echo date("l",mktime('0','0','0','7','9','2021'));
echo "<br>";
//mktime(hour, minute, second, month, day, year, is_dst)
echo mktime('0','0','0','12','31','2017');
echo "<br>";
echo date("m,y",mktime('0','0','0','12','31','2017'));
echo("<br>koriscenje funkcijau php-u:<br>");
//funkcija kojom se priprema poruka
function pripremiTekst($broj)
{
	$poruka='broj je neparan: ';
	if($broj%2==0)
		$poruka='broj je paran: ';
	return $poruka;
}
//funkcija kojom stampa broj (sa porukom)
function stampajBroj($broj,$poruka)
{
	echo $poruka.$broj;
}
//generisanje broja iz intrvala (1,100)
$broj=rand(1,100);
$poruka=pripremiTekst($broj);
stampajBroj($broj,$poruka);
?>