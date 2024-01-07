-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 27 Des 2022 pada 10.33
-- Versi server: 10.4.20-MariaDB
-- Versi PHP: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_thrifting`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `kodeadmin` varchar(15) NOT NULL,
  `namaadmin` varchar(30) NOT NULL,
  `passwordadmin` varchar(30) NOT NULL,
  `leveladmin` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_admin`
--

INSERT INTO `tbl_admin` (`kodeadmin`, `namaadmin`, `passwordadmin`, `leveladmin`) VALUES
('USR001', 'Ardyanto W.S', 'ardy', 'ADMIN'),
('USR002', 'Lintang Firdaus', 'lintang', 'KASIR');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_barang`
--

CREATE TABLE `tbl_barang` (
  `kodebarang` varchar(30) NOT NULL,
  `namabarang` varchar(30) NOT NULL,
  `hargajual` int(11) NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_barang`
--

INSERT INTO `tbl_barang` (`kodebarang`, `namabarang`, `hargajual`, `stok`) VALUES
('BRG001', 'Jaket', 200000, 1),
('BRG002', 'Celana Chinos', 130000, 0),
('BRG003', 'Crewneck', 200000, 0),
('BRG004', 'Celana Jeans', 250000, 0),
('BRG005', 'hodie', 100000, 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_detailjual`
--

CREATE TABLE `tbl_detailjual` (
  `nojual` varchar(30) NOT NULL,
  `kodebarang` varchar(30) NOT NULL,
  `namabarang` varchar(30) NOT NULL,
  `hargajual` int(11) NOT NULL,
  `jumlahjual` int(4) NOT NULL,
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_detailjual`
--

INSERT INTO `tbl_detailjual` (`nojual`, `kodebarang`, `namabarang`, `hargajual`, `jumlahjual`, `subtotal`) VALUES
('2212270002', 'BRG002', 'Celana Chinos', 130000, 3, 195000),
('2212270003', 'BRG002', 'Celana Chinos', 130000, 3, 195000),
('2212270005', 'BRG002', 'Celana Chinos', 130000, 1, 65000),
('2212270006', 'BRG003', 'Crewneck', 200000, 2, 400000),
('2212270007', 'BRG003', 'Crewneck', 200000, 1, 200000),
('2212270008', 'BRG003', 'Crewneck', 200000, 1, 100000),
('2212270009', 'BRG003', 'Crewneck', 200000, 1, 100000),
('2212270010', 'BRG003', 'Crewneck', 200000, 1, 100000),
('2212270011', 'BRG003', 'Crewneck', 200000, 1, 120000),
('2212270012', 'BRG003', 'Crewneck', 200000, 2, 240000),
('2212270013', 'BRG003', 'Crewneck', 200000, 2, 400000),
('2212270013', 'BRG005', 'hodie', 100000, 2, 100000),
('2212270014', 'BRG005', 'hodie', 100000, 1, 100000),
('2212270015', 'BRG005', 'hodie', 100000, 1, 100000),
('2212270016', 'BRG005', 'hodie', 100000, 2, 200000),
('2212270017', 'BRG005', 'hodie', 100000, 1, 100000),
('2212270018', 'BRG005', 'hodie', 100000, 1, 100000),
('2212270019', 'BRG005', 'hodie', 100000, 1, 100000),
('2212270020', 'BRG005', 'hodie', 100000, 1, 100000),
('2212270021', 'BRG002', 'Celana Chinos', 130000, 1, 65000),
('2212270022', 'BRG001', 'Jaket', 200000, 1, 100000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_jual`
--

CREATE TABLE `tbl_jual` (
  `nojual` varchar(30) NOT NULL,
  `tgljual` date NOT NULL,
  `jamjual` time NOT NULL,
  `totaljual` int(11) NOT NULL,
  `dibayar` int(11) NOT NULL,
  `kembali` int(11) NOT NULL,
  `kodepelanggan` varchar(11) NOT NULL,
  `kodeadmin` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_jual`
--

INSERT INTO `tbl_jual` (`nojual`, `tgljual`, `jamjual`, `totaljual`, `dibayar`, `kembali`, `kodepelanggan`, `kodeadmin`) VALUES
('2212260001', '2022-12-26', '08:40:18', 100000, 140000, 40000, 'PLG002', 'USR001'),
('2212260002', '2022-12-26', '09:11:47', 100000, 250000, 150000, 'PLG001', 'USR001'),
('2212260003', '2022-12-26', '09:13:48', 130000, 130000, 0, '', ''),
('2212270001', '2022-12-27', '11:22:32', 520000, 530000, 10000, 'PLG001', ''),
('2212270002', '2022-12-27', '11:34:41', 195000, 200000, 5000, 'PLG002', ''),
('2212270003', '2022-12-27', '11:35:57', 195000, 200000, 5000, 'PLG001', ''),
('2212270004', '2022-12-27', '11:39:26', 65000, 70000, 5000, 'PLG001', ''),
('2212270005', '2022-12-27', '11:41:42', 65000, 70000, 5000, 'PLG002', ''),
('2212270006', '2022-12-27', '11:44:41', 400000, 400000, 0, '', ''),
('2212270007', '2022-12-27', '11:47:31', 200000, 200000, 0, 'PLG001', ''),
('2212270008', '2022-12-27', '11:49:54', 100000, 1000000, 900000, 'PLG002', ''),
('2212270009', '2022-12-27', '11:51:34', 100000, 100000, 0, 'PLG001', ''),
('2212270010', '2022-12-27', '11:53:31', 100000, 100000, 0, 'PLG001', ''),
('2212270011', '2022-12-27', '11:59:26', 120000, 120000, 0, 'PLG001', ''),
('2212270012', '2022-12-27', '12:05:28', 240000, 250000, 10000, 'PLG001', ''),
('2212270013', '2022-12-27', '12:06:29', 400000, 400000, 0, '', ''),
('2212270014', '2022-12-27', '12:11:42', 100000, 100000, 0, 'PLG001', ''),
('2212270015', '2022-12-27', '12:13:16', 100000, 100000, 0, 'PLG002', 'Ardyanto W.'),
('2212270016', '2022-12-27', '12:15:11', 200000, 200000, 0, 'PLG002', 'USR002'),
('2212270017', '2022-12-27', '12:16:27', 100000, 100000, 0, 'PLG002', 'USR001'),
('2212270018', '2022-12-27', '12:17:45', 100000, 100000, 0, 'PLG002', 'USR002'),
('2212270019', '2022-12-27', '12:20:41', 100000, 100000, 0, 'PLG002', 'USR002'),
('2212270020', '2022-12-27', '12:21:58', 100000, 100000, 0, 'PLG002', 'USR002'),
('2212270021', '2022-12-27', '12:35:16', 65000, 70000, 5000, 'PLG002', 'USR002'),
('2212270022', '2022-12-27', '12:38:05', 100000, 200000, 100000, 'PLG001', 'USR002');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `kodepelanggan` varchar(10) NOT NULL,
  `namapelanggan` varchar(50) NOT NULL,
  `alamatpelanggan` varchar(100) NOT NULL,
  `telppelanggan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`kodepelanggan`, `namapelanggan`, `alamatpelanggan`, `telppelanggan`) VALUES
('PLG001', 'Ubaidillah', 'Simokerto', '082139820873'),
('PLG002', 'Sayyidah', 'Rangkah', '0817890123');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`kodeadmin`);

--
-- Indeks untuk tabel `tbl_barang`
--
ALTER TABLE `tbl_barang`
  ADD PRIMARY KEY (`kodebarang`);

--
-- Indeks untuk tabel `tbl_jual`
--
ALTER TABLE `tbl_jual`
  ADD PRIMARY KEY (`nojual`);

--
-- Indeks untuk tabel `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`kodepelanggan`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
