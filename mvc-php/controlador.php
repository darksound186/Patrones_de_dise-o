<?php
require "modelo.php";

$usuario = new Usuario();
$nombre = $usuario->obtenerNombre();

require "vista.php";
?>