-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 05 Şub 2023, 19:32:23
-- Sunucu sürümü: 10.4.24-MariaDB
-- PHP Sürümü: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `havayoludb`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bilet`
--

CREATE TABLE `bilet` (
  `idbilet` int(11) NOT NULL,
  `tip` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `koltukno` int(11) DEFAULT NULL,
  `ucret` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `bilet`
--

INSERT INTO `bilet` (`idbilet`, `tip`, `koltukno`, `ucret`) VALUES
(1, 'engelli', 10, 100),
(2, 'cocuk', 20, 102),
(3, 'yetişkin', 30, 108),
(4, 'yetişkin', 40, 120),
(5, 'yetişkin', 50, 130),
(6, 'yetişkin', 60, 150),
(7, 'yetişkin', 70, 115),
(8, 'cocuk', 80, 101),
(9, 'engelli', 90, 190),
(10, 'engelli', 11, 250),
(11, 'engelli', 12, 350),
(12, 'cocuk', 13, 110),
(13, 'cocuk', 14, 130),
(14, 'cocuk', 15, 140);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bilet_has_ucret`
--

CREATE TABLE `bilet_has_ucret` (
  `islem_id` int(11) NOT NULL,
  `idbilet` int(11) NOT NULL,
  `iducret` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `havayolu_sirketi`
--

CREATE TABLE `havayolu_sirketi` (
  `idhavayolu_sirketi` int(11) NOT NULL,
  `isim` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `havayolu_sirketi`
--

INSERT INTO `havayolu_sirketi` (`idhavayolu_sirketi`, `isim`) VALUES
(1, 'pegasus'),
(2, 'türk hava yolları');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hava_alani`
--

CREATE TABLE `hava_alani` (
  `idhava_alani` int(11) NOT NULL,
  `kod` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `isim` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `sehir` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ulke` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `hava_alani`
--

INSERT INTO `hava_alani` (`idhava_alani`, `kod`, `isim`, `sehir`, `ulke`) VALUES
(1, '24', 'sabiha gökçen', 'istanbul', 'türkiye'),
(2, '32', 'yunuseli hava alanı', 'bursa', 'türkiye'),
(3, '46', 'ankara hava alanı', 'ankara', 'türkiye'),
(4, '35', 'trabzon hava alanı', 'trabzon', 'türkiye');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `personel`
--

CREATE TABLE `personel` (
  `idpersonel` int(11) NOT NULL,
  `isim` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `soyisim` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `görev` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `personel`
--

INSERT INTO `personel` (`idpersonel`, `isim`, `soyisim`, `görev`) VALUES
(1, 'ali', 'oğlu', 'pilot'),
(2, 'veli', 'kahveci', 'kabin amiri'),
(3, 'mehmet', 'koç', 'kabin amiri'),
(4, 'ayşe', 'aslan', 'pilot');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `personel_has_ucus`
--

CREATE TABLE `personel_has_ucus` (
  `islem_id` int(11) NOT NULL,
  `idpersonel` int(11) NOT NULL,
  `iducus` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `personel_has_ucus`
--

INSERT INTO `personel_has_ucus` (`islem_id`, `idpersonel`, `iducus`) VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 2),
(4, 4, 2),
(5, 3, 3),
(6, 4, 3),
(7, 1, 4),
(8, 2, 4),
(9, 1, 5),
(10, 2, 5);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `rota`
--

CREATE TABLE `rota` (
  `idrota` int(11) NOT NULL,
  `rota_tipi` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `rota_tarifi` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `rota`
--

INSERT INTO `rota` (`idrota`, `rota_tipi`, `rota_tarifi`) VALUES
(1, 'düz', 'düm düz git'),
(2, 'yamuk', 'yamuk çizerek git'),
(3, 'dönmeli', 'döne döne uç');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ucak`
--

CREATE TABLE `ucak` (
  `iducak` int(11) NOT NULL,
  `tur` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `kayit_no` int(11) DEFAULT NULL,
  `havasirketi_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `ucak`
--

INSERT INTO `ucak` (`iducak`, `tur`, `kayit_no`, `havasirketi_id`) VALUES
(1, 'air bus 747', 101, 1),
(2, 'boing 808', 102, 1),
(3, 'boing 608', 108, 2),
(4, 'boing 708', 107, 2),
(5, 'air bus 647', 106, 2),
(6, 'air bus 547', 105, 2),
(7, 'air bus 447', 104, 1),
(8, 'boing 908', 103, 1),
(9, 'cessena 172', 131, 1),
(10, 'cessena 202', 129, 2);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ucak_has_bilet`
--

CREATE TABLE `ucak_has_bilet` (
  `idislem` int(11) NOT NULL,
  `iducak` int(11) DEFAULT NULL,
  `idbilet` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `ucak_has_bilet`
--

INSERT INTO `ucak_has_bilet` (`idislem`, `iducak`, `idbilet`) VALUES
(113, 1, 1),
(114, 1, 2),
(115, 1, 3),
(116, 1, 4),
(117, 1, 5),
(118, 1, 6),
(119, 1, 7),
(120, 1, 8),
(121, 1, 9),
(122, 1, 10),
(123, 1, 11),
(124, 1, 12),
(125, 1, 13),
(126, 1, 14),
(127, 2, 1),
(128, 2, 2),
(129, 2, 3),
(130, 2, 4),
(131, 2, 5),
(132, 2, 6),
(133, 2, 7),
(134, 2, 8),
(135, 2, 9),
(136, 2, 10),
(137, 2, 11),
(138, 2, 12),
(139, 2, 13),
(140, 2, 14),
(141, 3, 1),
(142, 3, 2),
(143, 3, 3),
(144, 3, 4),
(145, 3, 5),
(146, 3, 6),
(147, 3, 7),
(148, 3, 8),
(149, 3, 9),
(150, 3, 10),
(151, 3, 11),
(152, 3, 12),
(153, 3, 13),
(154, 3, 14),
(155, 4, 1),
(156, 4, 2),
(157, 4, 3),
(158, 4, 4),
(159, 4, 5),
(160, 4, 6),
(161, 4, 7),
(162, 4, 8),
(163, 4, 9),
(164, 4, 10),
(165, 4, 11),
(166, 4, 12),
(167, 4, 13),
(168, 4, 14),
(169, 5, 1),
(170, 5, 2),
(171, 5, 3),
(172, 5, 4),
(173, 5, 5),
(174, 5, 6),
(175, 5, 7),
(176, 5, 8),
(177, 5, 9),
(178, 5, 10),
(179, 5, 11),
(180, 5, 12),
(181, 5, 13),
(182, 5, 14),
(183, 6, 1),
(184, 6, 2),
(185, 6, 3),
(186, 6, 4),
(187, 6, 5),
(188, 6, 6),
(189, 6, 7),
(190, 6, 8),
(191, 6, 9),
(192, 6, 10),
(193, 6, 11),
(194, 6, 12),
(195, 6, 13),
(196, 6, 14),
(197, 7, 1),
(198, 7, 2),
(199, 7, 3),
(200, 7, 4),
(201, 7, 5),
(202, 7, 6),
(203, 7, 7),
(204, 7, 8),
(205, 7, 9),
(206, 7, 10),
(207, 7, 11),
(208, 7, 12),
(209, 7, 13),
(210, 7, 14),
(211, 8, 1),
(212, 8, 2),
(213, 8, 3),
(214, 8, 4),
(215, 8, 5),
(216, 8, 6),
(217, 8, 7),
(218, 8, 8),
(219, 8, 9),
(220, 8, 10),
(221, 8, 11),
(222, 8, 12),
(223, 8, 13),
(224, 8, 14),
(225, 9, 1),
(226, 9, 2),
(227, 9, 3),
(228, 9, 4),
(229, 9, 5),
(230, 9, 6),
(231, 9, 7),
(232, 9, 8),
(233, 9, 9),
(234, 9, 10),
(235, 9, 11),
(236, 9, 12),
(237, 9, 13),
(238, 9, 14),
(239, 10, 1),
(240, 10, 2),
(241, 10, 3),
(242, 10, 4),
(243, 10, 5),
(244, 10, 6),
(245, 10, 7),
(246, 10, 8),
(247, 10, 9),
(248, 10, 10),
(249, 10, 11),
(250, 10, 12),
(251, 10, 13),
(252, 10, 14);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ucak_has_hava_alani`
--

CREATE TABLE `ucak_has_hava_alani` (
  `islem_id` int(11) NOT NULL,
  `iducak` int(11) NOT NULL,
  `idhava_alani` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `ucak_has_hava_alani`
--

INSERT INTO `ucak_has_hava_alani` (`islem_id`, `iducak`, `idhava_alani`) VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 1),
(4, 4, 1),
(5, 5, 2),
(6, 6, 2),
(7, 7, 3),
(8, 8, 3),
(9, 9, 4),
(10, 10, 4);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ucak_has_ucus`
--

CREATE TABLE `ucak_has_ucus` (
  `islem_id` int(11) NOT NULL,
  `iducak` int(11) NOT NULL,
  `iducus` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `ucak_has_ucus`
--

INSERT INTO `ucak_has_ucus` (`islem_id`, `iducak`, `iducus`) VALUES
(1, 1, 1),
(2, 2, 6),
(3, 3, 2),
(4, 4, 2),
(5, 5, 3),
(6, 6, 3),
(7, 7, 4),
(8, 8, 4),
(9, 9, 5),
(10, 10, 5);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ucret`
--

CREATE TABLE `ucret` (
  `iducret` int(11) NOT NULL,
  `odemetipi` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `sartlar` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ucret` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ucus`
--

CREATE TABLE `ucus` (
  `iducus` int(11) NOT NULL,
  `hareket_yeri` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `varis_yeri` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `hareket_tarihi` datetime DEFAULT NULL,
  `varis_tarihi` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `ucus`
--

INSERT INTO `ucus` (`iducus`, `hareket_yeri`, `varis_yeri`, `hareket_tarihi`, `varis_tarihi`) VALUES
(1, 'istanbul', 'bursa', '2022-12-01 12:30:00', '2022-12-01 16:30:00'),
(2, 'istanbul', 'ankara', '2022-12-02 13:30:00', '2022-12-02 17:30:00'),
(3, 'bursa', 'istanbul', '2022-12-03 14:30:00', '2022-12-03 18:30:00'),
(4, 'bursa', 'trabzon', '2022-12-04 15:30:00', '2022-12-04 23:30:00'),
(5, 'ankara', 'istanbul', '2022-12-05 16:30:00', '2022-12-05 20:30:00'),
(6, 'istanbul', 'bursa', '2022-12-12 14:44:00', '2022-12-12 18:32:00');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ucus_has_rota`
--

CREATE TABLE `ucus_has_rota` (
  `islem_id` int(11) NOT NULL,
  `idrota` int(11) NOT NULL,
  `iducus` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `ucus_has_rota`
--

INSERT INTO `ucus_has_rota` (`islem_id`, `idrota`, `iducus`) VALUES
(1, 1, 1),
(2, 1, 2),
(3, 2, 3),
(4, 2, 4),
(5, 3, 5);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ucus_has_yolcu`
--

CREATE TABLE `ucus_has_yolcu` (
  `islem_id` int(11) NOT NULL,
  `idyolcu` int(11) NOT NULL,
  `iducus` int(11) NOT NULL,
  `iducak` int(11) NOT NULL,
  `idbilet` int(11) NOT NULL,
  `islem_tarihi` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `ucus_has_yolcu`
--

INSERT INTO `ucus_has_yolcu` (`islem_id`, `idyolcu`, `iducus`, `iducak`, `idbilet`, `islem_tarihi`) VALUES
(11, 3, 5, 10, 2, '2022-12-24 11:54:41'),
(15, 4, 4, 7, 1, '2022-12-24 12:08:59'),
(17, 5, 6, 2, 13, '2022-12-24 12:15:44'),
(18, 6, 4, 7, 2, '2022-12-24 15:08:33'),
(19, 6, 6, 2, 4, '2022-12-24 15:09:25'),
(20, 7, 5, 9, 2, '2023-02-05 21:23:31');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `yolcu`
--

CREATE TABLE `yolcu` (
  `idyolcu` int(11) NOT NULL,
  `isim` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `soyisim` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `yas` int(11) DEFAULT NULL,
  `cinsiyet` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `adres` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `email` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `heskodu` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL,
  `tcno` varchar(45) COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `yolcu`
--

INSERT INTO `yolcu` (`idyolcu`, `isim`, `soyisim`, `yas`, `cinsiyet`, `adres`, `email`, `heskodu`, `tcno`) VALUES
(3, 'test', 'test soy ad', 18, 'erkek', 'bursa osmangazi', 'test@gmail.com', '432', '12'),
(4, 'esma', 'eş', 45, 'kadın', 'yok', 'yok', 'yok', '4245'),
(5, 'aleyna', 'gündüz', 29, 'Kadın', 'Bursa Yıldırım', 'yok', '124QGD', '98763'),
(6, 'emre', 'gunduz', 45, 'erkek', 'yok', 'yok', 'yok', '6789'),
(7, 'test isim', 'test soy isim', 23, 'Erkek', 'türkiye....', 'test@gmail.com', '3245343', '34567823345');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `bilet`
--
ALTER TABLE `bilet`
  ADD PRIMARY KEY (`idbilet`);

--
-- Tablo için indeksler `bilet_has_ucret`
--
ALTER TABLE `bilet_has_ucret`
  ADD PRIMARY KEY (`islem_id`);

--
-- Tablo için indeksler `havayolu_sirketi`
--
ALTER TABLE `havayolu_sirketi`
  ADD PRIMARY KEY (`idhavayolu_sirketi`);

--
-- Tablo için indeksler `hava_alani`
--
ALTER TABLE `hava_alani`
  ADD PRIMARY KEY (`idhava_alani`);

--
-- Tablo için indeksler `personel`
--
ALTER TABLE `personel`
  ADD PRIMARY KEY (`idpersonel`);

--
-- Tablo için indeksler `personel_has_ucus`
--
ALTER TABLE `personel_has_ucus`
  ADD PRIMARY KEY (`islem_id`),
  ADD KEY `FK_personel_id` (`idpersonel`),
  ADD KEY `FK_ucus_id` (`iducus`);

--
-- Tablo için indeksler `rota`
--
ALTER TABLE `rota`
  ADD PRIMARY KEY (`idrota`);

--
-- Tablo için indeksler `ucak`
--
ALTER TABLE `ucak`
  ADD PRIMARY KEY (`iducak`);

--
-- Tablo için indeksler `ucak_has_bilet`
--
ALTER TABLE `ucak_has_bilet`
  ADD PRIMARY KEY (`idislem`);

--
-- Tablo için indeksler `ucak_has_hava_alani`
--
ALTER TABLE `ucak_has_hava_alani`
  ADD PRIMARY KEY (`islem_id`);

--
-- Tablo için indeksler `ucak_has_ucus`
--
ALTER TABLE `ucak_has_ucus`
  ADD PRIMARY KEY (`islem_id`);

--
-- Tablo için indeksler `ucret`
--
ALTER TABLE `ucret`
  ADD PRIMARY KEY (`iducret`);

--
-- Tablo için indeksler `ucus`
--
ALTER TABLE `ucus`
  ADD PRIMARY KEY (`iducus`);

--
-- Tablo için indeksler `ucus_has_rota`
--
ALTER TABLE `ucus_has_rota`
  ADD PRIMARY KEY (`islem_id`);

--
-- Tablo için indeksler `ucus_has_yolcu`
--
ALTER TABLE `ucus_has_yolcu`
  ADD PRIMARY KEY (`islem_id`),
  ADD KEY `FK_yolcu_id` (`idyolcu`);

--
-- Tablo için indeksler `yolcu`
--
ALTER TABLE `yolcu`
  ADD PRIMARY KEY (`idyolcu`),
  ADD UNIQUE KEY `tcno` (`tcno`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `bilet`
--
ALTER TABLE `bilet`
  MODIFY `idbilet` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Tablo için AUTO_INCREMENT değeri `bilet_has_ucret`
--
ALTER TABLE `bilet_has_ucret`
  MODIFY `islem_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `hava_alani`
--
ALTER TABLE `hava_alani`
  MODIFY `idhava_alani` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Tablo için AUTO_INCREMENT değeri `personel`
--
ALTER TABLE `personel`
  MODIFY `idpersonel` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Tablo için AUTO_INCREMENT değeri `personel_has_ucus`
--
ALTER TABLE `personel_has_ucus`
  MODIFY `islem_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Tablo için AUTO_INCREMENT değeri `rota`
--
ALTER TABLE `rota`
  MODIFY `idrota` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Tablo için AUTO_INCREMENT değeri `ucak`
--
ALTER TABLE `ucak`
  MODIFY `iducak` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Tablo için AUTO_INCREMENT değeri `ucak_has_bilet`
--
ALTER TABLE `ucak_has_bilet`
  MODIFY `idislem` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=253;

--
-- Tablo için AUTO_INCREMENT değeri `ucak_has_hava_alani`
--
ALTER TABLE `ucak_has_hava_alani`
  MODIFY `islem_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Tablo için AUTO_INCREMENT değeri `ucak_has_ucus`
--
ALTER TABLE `ucak_has_ucus`
  MODIFY `islem_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Tablo için AUTO_INCREMENT değeri `ucret`
--
ALTER TABLE `ucret`
  MODIFY `iducret` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `ucus`
--
ALTER TABLE `ucus`
  MODIFY `iducus` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Tablo için AUTO_INCREMENT değeri `ucus_has_rota`
--
ALTER TABLE `ucus_has_rota`
  MODIFY `islem_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tablo için AUTO_INCREMENT değeri `ucus_has_yolcu`
--
ALTER TABLE `ucus_has_yolcu`
  MODIFY `islem_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Tablo için AUTO_INCREMENT değeri `yolcu`
--
ALTER TABLE `yolcu`
  MODIFY `idyolcu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `personel_has_ucus`
--
ALTER TABLE `personel_has_ucus`
  ADD CONSTRAINT `FK_personel_id` FOREIGN KEY (`idpersonel`) REFERENCES `personel` (`idpersonel`),
  ADD CONSTRAINT `FK_ucus_id` FOREIGN KEY (`iducus`) REFERENCES `ucus` (`iducus`);

--
-- Tablo kısıtlamaları `ucus_has_yolcu`
--
ALTER TABLE `ucus_has_yolcu`
  ADD CONSTRAINT `FK_yolcu_id` FOREIGN KEY (`idyolcu`) REFERENCES `yolcu` (`idyolcu`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
