-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               10.2.3-MariaDB-log - mariadb.org binary distribution
-- Server OS:                    Win32
-- HeidiSQL Version:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping data for table project.absences: ~0 rows (approximately)
DELETE FROM `absences`;
/*!40000 ALTER TABLE `absences` DISABLE KEYS */;
/*!40000 ALTER TABLE `absences` ENABLE KEYS */;

-- Dumping data for table project.eleves: ~11 rows (approximately)
DELETE FROM `eleves`;
/*!40000 ALTER TABLE `eleves` DISABLE KEYS */;
INSERT INTO `eleves` (`codeElev`, `nom`, `prenom`, `niveau`, `dateInsc`, `Elevescol`, `anneeDiplom`, `code_Fil`) VALUES
	('111', 'Ajaanit', 'Taoufik', 2, '2019-02-28 20:34:22', NULL, NULL, 'ginf'),
	('12', 'zaza', 'mouad', 2, '2019-02-28 20:59:43', NULL, NULL, 'gsea'),
	('1213', 'enaime', 'hamza', 2, '2019-02-28 20:34:22', NULL, NULL, 'ginf'),
	('1224', 'hamaoui', 'ayoub', 2, '2019-02-28 20:34:22', NULL, NULL, 'ginf'),
	('13', 'sai', 'ayoub', 1, '2019-02-28 20:59:57', NULL, NULL, 'gsea'),
	('14', 'yatim', 'mohammed amine', 2, '2019-02-28 21:00:24', NULL, NULL, 'gind'),
	('15', 'mrabet', 'ismail', 1, '2019-02-28 21:01:03', NULL, NULL, 'gind'),
	('16', 'melhouf', 'soufiane', 1, '2019-02-28 21:01:32', NULL, NULL, 'gstr'),
	('17', 'rachidi', 'adnane', 1, '2019-02-28 21:03:20', NULL, NULL, 'gstr'),
	('18', 'moussaid', 'ziad', 1, '2019-02-28 21:03:38', NULL, NULL, 'gsea'),
	('89', 'bouhara', 'mehdi', 2, '2019-02-28 20:35:18', NULL, NULL, 'ginf');
/*!40000 ALTER TABLE `eleves` ENABLE KEYS */;

-- Dumping data for table project.filieres: ~6 rows (approximately)
DELETE FROM `filieres`;
/*!40000 ALTER TABLE `filieres` DISABLE KEYS */;
INSERT INTO `filieres` (`codeF`, `designation`) VALUES
	('cp', 'classes préparatoires'),
	('g3ei', 'génie eco-energitique et environement indistruelle'),
	('gind', 'génie indistruelle'),
	('ginf', 'génie informatique'),
	('gsea', 'génie des systemes electroniques et automatiques'),
	('gstr', 'génie des systemes de telecomunications et réseaux');
/*!40000 ALTER TABLE `filieres` ENABLE KEYS */;

-- Dumping data for table project.matieres: ~9 rows (approximately)
DELETE FROM `matieres`;
/*!40000 ALTER TABLE `matieres` DISABLE KEYS */;
INSERT INTO `matieres` (`codeMat`, `designation`, `poids`, `codeModule`) VALUES
	('ginf111', 'programmation en c', 0.5, 'ginf11'),
	('ginf112', 'programmation web', 0.5, 'ginf11'),
	('ginf121', 'statistique', 0.4, 'ginf12'),
	('ginf122', 'optimisation', 0.3, 'ginf12'),
	('ginf123', 'analyse numerique', 0.3, 'ginf12'),
	('ginf131', 'numerique', 0.5, 'ginf13'),
	('ginf132', 'analogique', 0.5, 'ginf13'),
	('ginf211', 'java', 0.6, 'ginf21'),
	('ginf212', 'xml', 0.4, 'ginf21');
/*!40000 ALTER TABLE `matieres` ENABLE KEYS */;

-- Dumping data for table project.modules: ~4 rows (approximately)
DELETE FROM `modules`;
/*!40000 ALTER TABLE `modules` DISABLE KEYS */;
INSERT INTO `modules` (`codeModule`, `designation`, `niveau`, `nbr_matieres`, `semestre`, `code_Fil`) VALUES
	('ginf11', 'programmation', '1', 2, 1, 'ginf'),
	('ginf12', 'statistique', '1', 3, 1, 'ginf'),
	('ginf13', 'electronique', '1', 2, 1, 'ginf'),
	('ginf21', 'java', '2', 2, 1, 'ginf');
/*!40000 ALTER TABLE `modules` ENABLE KEYS */;

-- Dumping data for table project.moyennes: ~0 rows (approximately)
DELETE FROM `moyennes`;
/*!40000 ALTER TABLE `moyennes` DISABLE KEYS */;
/*!40000 ALTER TABLE `moyennes` ENABLE KEYS */;

-- Dumping data for table project.notes: ~6 rows (approximately)
DELETE FROM `notes`;
/*!40000 ALTER TABLE `notes` DISABLE KEYS */;
INSERT INTO `notes` (`codeElev`, `codeMat`, `note`) VALUES
	('111', 'ginf111', 18),
	('111', 'ginf112', 15.2),
	('12', 'ginf111', 10.8),
	('12', 'ginf112', 19),
	('1213', 'ginf111', 19),
	('14', 'ginf112', 13);
/*!40000 ALTER TABLE `notes` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
