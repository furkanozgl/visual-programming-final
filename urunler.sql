-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost
-- Üretim Zamanı: 02 Oca 2023, 17:22:31
-- Sunucu sürümü: 8.0.17
-- PHP Sürümü: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `urunler`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `alet`
--

CREATE TABLE `alet` (
  `aletid` int(11) NOT NULL,
  `aletad` varchar(50) NOT NULL,
  `hakkinda` varchar(250) NOT NULL,
  `adet` int(11) NOT NULL,
  `fiyat` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `dekor`
--

CREATE TABLE `dekor` (
  `dekorid` int(11) NOT NULL,
  `dekorad` varchar(50) NOT NULL,
  `hakkinda` varchar(250) NOT NULL,
  `adet` int(11) NOT NULL,
  `fiyat` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tohum`
--

CREATE TABLE `tohum` (
  `tohumid` int(11) NOT NULL,
  `tohumad` varchar(50) NOT NULL,
  `hakkinda` text NOT NULL,
  `adet` int(11) NOT NULL,
  `fiyat` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `tohum`
--

INSERT INTO `tohum` (`tohumid`, `tohumad`, `hakkinda`, `adet`, `fiyat`) VALUES
(1, 'lavanta', 'lavanta ciceği  (mor cicek) tohumu ', 20, 25),
(5, 'lale', 'asdkfls', 20, 30);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `alet`
--
ALTER TABLE `alet`
  ADD PRIMARY KEY (`aletid`);

--
-- Tablo için indeksler `dekor`
--
ALTER TABLE `dekor`
  ADD PRIMARY KEY (`dekorid`);

--
-- Tablo için indeksler `tohum`
--
ALTER TABLE `tohum`
  ADD PRIMARY KEY (`tohumid`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `alet`
--
ALTER TABLE `alet`
  MODIFY `aletid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `dekor`
--
ALTER TABLE `dekor`
  MODIFY `dekorid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `tohum`
--
ALTER TABLE `tohum`
  MODIFY `tohumid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
