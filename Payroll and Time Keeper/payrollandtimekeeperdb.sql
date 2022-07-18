-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 07, 2019 at 12:55 AM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `payrollandtimekeeperdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `adminID` int(11) NOT NULL,
  `adminNickname` varchar(60) NOT NULL,
  `adminName` varchar(60) NOT NULL,
  `Username` varchar(60) NOT NULL,
  `Password` varchar(60) NOT NULL,
  `adminProfile` mediumblob NOT NULL,
  `Email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_admin`
--

INSERT INTO `tbl_admin` (`adminID`, `adminNickname`, `adminName`, `Username`, `Password`, `adminProfile`, `Email`) VALUES
(14, 'Administrator', 'Administrator', 'admin', 'admin', 0x89504e470d0a1a0a0000000d49484452000000c8000000c80806000000ad58ae9e0000000467414d410000b18f0bfc6105000000097048597300000b1300000b1301009a9c1800000cd349444154785eeddd79f06f731dc77159922d5b2462a294a894a568b1ddc224cb9864104559274b32216684265b8b162a516e5dd44da642544421a92c2db2952ca9c91e25b2d4f3655cd4bc7ff77ebfe77ccf6739e7f59c794c7fe477eeeffe3ee77b7fdfef399ff3f9cce59c73ce39e79c73ce39e79c73ce39e79c73ce39e79c73ce39e79c73ce393775f36205ac89f5b119b6c5fbb01f0ec5613810fb6237ec846da0ff760d2c01e7aa6f6eac830fe3dbb8098fe13f13f077fc1adfc5f1d08b68253857747a516c8cafe26e44277797eec04cec8d57c1b9225a0c7a5b742ba2133797df42bfc1968373c97b3e0e87def2442768291ec705d801f3c0b94e7b0ef4c1fa4e442764c96ec076d0dfc1b939f65cac067d76d8e4a9ff7d1b36c2aad0ffffec7415ea2244275f4d7e83ade0dcffb43cf687ae00dd88395d59d2ffff479c87cfe35e44ff5dadcec73270036e11ec839fe1094427ca90dd852de10696de1ee98551e367851cbe8c05e106d03ba0b746d1896053bb0c8bc2f5345dc63c1a7e2bd5dc5578015ccf5a0a17221a741bcfefb12c5c4f5a1ad7231a6c6b4657f9344bc0559e06f11a44836ced9c0bdf54acb8857039a2c1b5c9d0741a5769d3110daa4d8e2e786c0e57597ad8281a509b3c4ddff7c35a15a52923f7211a4ceb86a6dab84ad2dca86810ad3b9a97f66ab8c29b866800ad7b9ac9ec0a4e971caf44347896c6167085a6877da241b374345bc1159a9eb38e06cdd2d2c364aeb0de8c68b02cbd13e10a6b06a2c1b2f41e8416ad7085b4241e46345896c72e7085b417a241b27cb462a42b24df182c8fd6039b0f2e739ab1ebb75765da102e735a71231a1ccbef137099fb22a2c1b1fcb4cabccb9c06211a1ccbef51fcffea932e610b4083100d8e956175b84cad8b68506aa2e7563445463361bf075d1e95b37131ae45e92bc4cfcebbe132a59511a3412995aeb669bd5bedcba16dd6748373d4b416d506d05e233ac6bf10fd19a539062e5327231a94d268e188f740eb004faa85b1232e41f4679642f7a85ca64a5f084e2f8cf5d0756f44a92f14edbfe832f507448392db03783f52af19b533f46747df532ef7c365489b623e82685072ba0e2f47ae564669ab48fa526f86b4f964341839698f91c5913b7df8bf1ad1f79883d7f1cdd05a880623173d0b3fc90fe16dd362dda56cf1f05ab8c469225c341839fc0d25fe2ba99b74254ce4d4be8e2e715a3d231a8c1cb4214fa91d82e87b4ee99d7089db1ed160a476264a6e7edc86e87b4f651bb8c4ed8e683052d226fcaf40e9ed8de8fb4fc52f900c9530cd44db454f225db25e1bba777230349de4bdd087db49dc4bd1020a0f21fa3ba4e0174886f644341829b55d455027bf7e13de82e8f8a22b513ba16d67213a7e0a7e816448ffda468391ca3fa0f7f74dd3d7ea375074ecc817d0a69c6f49fd02c99026ff4583918a66d4b6e93444c79d9d5dd134adbc1e1d33055fc5ca50eeab586db61e7b3ba263cec95f302f9aa41546723d5cb6295ce2b6463418a9bc0b4dfb31a2638ea2cd4db7d97dd6e9d2ebe112f7164483914ad341d75c2d5d1e8e8e398ac3d0b42b101db36b2f854b9cee3f448391ca4bd0a4b65364be8ea65d80e8985d2b6102e7e0d20f3d1a8c54f4086c93f48c7674bc51e959f5a6fd00d131bba4df96de4b3d53ff4634282968fa86ded38f4b3bc246c71b559b17488ea70eef81cbd49f110d4a9f9d84a6dd88e8985dd29fe932a567bea341e9b33dd0245de6cdf11b574b17b94c9d816850fa4aefe75f8c26ad89e8985d6b7351c1b5ec284483d2576df6dc3808d131bbf671b84c9530e53d152d50b10a9af62b44c7ed9a2695ba4c6d826850fae88368da1a888e99c2667099d2f23ad1a0f44ddbf7f133111d37054d927499d294f136d3366aa059c36dd6957a039e4074ec14bcdb6de6723f6fdd254d0dd1160f4dd30b2be7fe29f7c265aecdccd8929d83e7a14dc7213a762a57c1654e7796a3c1a9991ea66abb43ec56c8f9d64abc1574011d8968706a753cda4eeed3620f0f223a7e4a27c0656c7f3c8668706a7434daa669f87af2303a7e6a1a9b7de132b41ba241a9d589689b963f2d714b082d61e412b6126ad9826c143fc43c68935e1c37203a7e6effc40a70899a8e68206aa4b7434d1fbe9a95de5695b292fb54b49fbd4b906e3cf5e9b747dbc5e7f4e8f1ed888e5d125d345810aee3b6443400356abbb6d66ba0ad17a263974873e75cc71d81e8875f234d03699a5655d19deae8b8a5fa085cc7f5e5f3c72fd134dde7d0e698d1714bd676f9543742da8f23fae1d7a6e9f4757da0afe13347e46b701d773aa21f7e6d9a3efc54f33f1027c375dca710fdf06b72279a54d2be8c4d7c0caee3726f7b3009ba31d8a45c2b234eca0e701db72aa21f7e4d3e8771d39de8dcb373db5a112e4137231a805a1c8071d37a58d1b16a712d5ca26abf17a2f579c7ed1444c7aa85f65e74897a116a9e6ed264a58f9a9f9cd476754bc225ec5844835183f5316ed7203a560df41bdf256e61fc09d180946e5d8cdbad888e55baebd166e109d722cd47aaf1add6b938754c0f233a56c9f41cc8ea7019d3ecde9cfb84584c2f686d56ea0ae8ad68bb318d4d8ea6e0af0757507ae454f3b46abf995633fdec67e0857085a6f57acf433480d61dade0b8325c054d433488d69dfde02a492b84dc8568206df2f4d6aae9ce572e535a45231a4c9b3ced9eeb2aeb4d8806b324ba3cad7578b786d6fad28a2d8b6135ec820b117d5d697685abb01257199ce50a8cf2a1569fa7ee40748c12e846eda27015a65534a241cd4dbf19c6997ea167414a9d6aa2bbfcaed2743dbeb4bbec7fc51218b7b551e242dd6d962e7205f40d44039bcb07d034ed55181d3317ed9ceb2a4f131aa3c1cd41fb292e8ea66d8ce8b8b96c07d7837e8a688053bb116dd28b2b3a6e0eb7605eb81eb429a2414eed32b4ed5144c74e6d4fb81ea5cbaad140a7d466b951a57fb14b988ca92b6a6db6a6760556c26f91fbd066ffc157223a6e6a5a9bccf5b012ee4c3779dc7656da93313a664abf43dbddb05ca1ad81dc6f51ce4293b467ba3e1847c74cc94f09f6bc12d697da11e3a6ad03a263a574365ccfd3f601b9379ed1ddfd9d304afa60fe6944c749e921682f4437804ad942fa3b580751f3410b525c85e86b533b086e20e94a524953c9b5c8c18f700666e25268d3cbe8bfcd4197a7fdc17c60e9ed42492761a9b47c8f9e4f71036c674427853d631fb80157da6cdf92f8aa957bf269b89b109d2043a6758fbd22bb7b326dc8af7564a31365887449f77570eee9b64774b20c51931b996e001d89e8841912ef44eba64cf747be89e8c41902fddddbcc367603687e5c84e804ea336df1a6bfbb73734c0bb85d8de844eaa32bb1089c1b392d19741da213aa4ff47cc752706eecb49bae165a884eac3ed03f00decbc3b54aab96f7f146a25e1cfa07c0b9d6e944ba16d18956236d29edb7556ea2e9412b7d988d4eb89afc1c6d16af736eca7475eb0244275e0db4fdf44270aeb3b41e941e6c8a4ec0927d055e09d12549779b8f46742296e83038973ced0255daf60acfa6a7013509d3b9e4e9ed8a1681d34345d1c95902adc1a54521fcd6ca75dedcd0c2731f823eec3e80e8a42c91bed7efe300e8390f4f487413490b3bec8e33710fa293af4677e35bd0f2472bc2b991d2843dad45750286f418ae363b3d11fabb2f0ce79e4e8fdb1e0c6db253cade1b39e9a2c3c53810fad9b881a51b655be04bb80dd14962cfb81dfa59e967b6205c0f5b0e7be17ce8d2677422d89c694f747dd8df03cbc255dcaad03ee9bf4009bb32f58d7ea65a92f410e867ed2a487b891f831b100daa75473ff3a3b0165c4169408ec5cd8806ced2d3a273c7415b70bb0ce966977e53f845513e8d91e6adad0ed7612b409f29faf4e0d2d068ec0e856f4e4e28ad9bab1d557f027fd0ee0f8da5ee3b696cf58c8d1b23cd13da10a7419715a31fb0f587d6019e818de03962b36919689b2fafb43e5cfabca2b7d13a17dc534d83a6657b9a87cda2e92e9a20aadf2a836c016826a9162d8b7e4066b3e883bd66410ce259fae5a1cbb37d9a3a6e6968eb6e9d3b5aa7ac77ad8253e1b751d696de7e4d472f3616d513787a2ff938a2bfac5953ba54ac7de6d74475e94eb71e4b8dfe626693760eaad8324e77484f876fea596a3ae7f418f1ca282eadf3fa593c82e89b374b459f51742e16b143afee7cea72adae3044dfac592eba52aa07bbb41a4d967415e15244df9c5929f45057d267ebb5089976832d794541b367d3b97a383a5f404f37fa2e43f44d9895ee0abc0c9db4397c07dc6a773fb442cb44d383f9d11f6656235d12d6835badd355aa4f22fa43cc6aa7f5be1a5fe5d2179e82e8c0667da18d851a3da87504a2039af58d1695182b7d20f774111b926d31525a52529ff4a38398f5d57d1869dff8cf203a8059dfe933f76c5b1a5a6522fa62b3bed3037db3fd2db20fa22f341b0abd06a6ec24445f6436143331659720fa22b3a1b81c53e665786ce8aec19469fda18f9a0d981eb272ce39e79c73ce39e79c73ce39e79c73ce39e79c73ce39e79c73ce39e7ca6daeb9fe0b2c4efef6d7c3133a0000000049454e44ae426082, 'administrator@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_benefits`
--

CREATE TABLE `tbl_benefits` (
  `govID` int(11) NOT NULL,
  `EmployeeCode` varchar(60) NOT NULL,
  `SSS` int(11) NOT NULL,
  `TIN` int(11) NOT NULL,
  `pagIbig` int(11) NOT NULL,
  `philHealth` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_benefits`
--

INSERT INTO `tbl_benefits` (`govID`, `EmployeeCode`, `SSS`, `TIN`, `pagIbig`, `philHealth`) VALUES
(61, 'QCU-52813', 123456789, 1263456789, 123456789, 123456789);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_course`
--

CREATE TABLE `tbl_course` (
  `courseID` int(11) NOT NULL,
  `courseCode` varchar(60) NOT NULL,
  `courseDesc` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_department`
--

CREATE TABLE `tbl_department` (
  `departmentID` int(11) NOT NULL,
  `departmentCode` varchar(60) NOT NULL,
  `departmentDesc` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_department`
--

INSERT INTO `tbl_department` (`departmentID`, `departmentCode`, `departmentDesc`) VALUES
(2, 'ENTREP', 'Entrepreneur Department'),
(3, 'IE', 'Engineering Department'),
(4, 'IT', 'IT Department'),
(8, 'AC', 'Accounting Department');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_employee`
--

CREATE TABLE `tbl_employee` (
  `employeeID` int(11) NOT NULL,
  `profile` mediumblob NOT NULL,
  `EmployeeCode` varchar(60) NOT NULL,
  `Password` varchar(60) NOT NULL,
  `Firstname` varchar(60) NOT NULL,
  `MiddleName` varchar(60) NOT NULL,
  `LastName` varchar(60) NOT NULL,
  `Gender` varchar(60) NOT NULL,
  `Email` varchar(60) NOT NULL,
  `Degree` varchar(100) NOT NULL,
  `leaveLeft` int(11) NOT NULL,
  `rates` int(11) NOT NULL,
  `hours` int(11) NOT NULL,
  `monthlySalary` varchar(11) NOT NULL,
  `Department` varchar(60) NOT NULL,
  `position` varchar(60) NOT NULL,
  `hired` date NOT NULL,
  `Employment` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_leave`
--

CREATE TABLE `tbl_leave` (
  `leaveID` int(11) NOT NULL,
  `EmployeeCode` varchar(60) NOT NULL,
  `FirstName` varchar(60) NOT NULL,
  `LastName` varchar(60) NOT NULL,
  `Department` varchar(60) NOT NULL,
  `LeaveType` varchar(60) NOT NULL,
  `leaveLeft` int(11) NOT NULL,
  `startDay` date NOT NULL,
  `endDay` date NOT NULL,
  `reasons` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_personalinfo`
--

CREATE TABLE `tbl_personalinfo` (
  `personalID` int(11) NOT NULL,
  `employeeCode` varchar(255) NOT NULL,
  `FirstName` varchar(60) NOT NULL,
  `MiddleName` varchar(60) NOT NULL,
  `LastName` varchar(60) NOT NULL,
  `Gender` varchar(20) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Birthday` date NOT NULL,
  `MartialStatus` varchar(100) NOT NULL,
  `Contact` varchar(20) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `City` varchar(60) NOT NULL,
  `zipCode` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_room`
--

CREATE TABLE `tbl_room` (
  `roomID` int(11) NOT NULL,
  `roomCode` varchar(60) NOT NULL,
  `roomDesc` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_salary`
--

CREATE TABLE `tbl_salary` (
  `salaryID` int(11) NOT NULL,
  `EmployeeCode` varchar(60) NOT NULL,
  `FirstName` varchar(60) NOT NULL,
  `MiddleName` varchar(60) NOT NULL,
  `LastName` varchar(60) NOT NULL,
  `Department` varchar(100) NOT NULL,
  `Position` varchar(100) NOT NULL,
  `rates` int(60) NOT NULL,
  `hours` int(60) NOT NULL,
  `work` int(60) NOT NULL,
  `sss` int(60) NOT NULL,
  `tin` int(60) NOT NULL,
  `pagibig` int(60) NOT NULL,
  `philhealth` int(60) NOT NULL,
  `gross` int(60) NOT NULL,
  `deduction` int(60) NOT NULL,
  `net` int(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_schedule`
--

CREATE TABLE `tbl_schedule` (
  `scheduleID` int(11) NOT NULL,
  `EmployeeCode` varchar(60) NOT NULL,
  `Code` varchar(60) NOT NULL,
  `FirstName` varchar(60) NOT NULL,
  `LastName` varchar(60) NOT NULL,
  `Department` varchar(100) NOT NULL,
  `Year` varchar(60) NOT NULL,
  `Section` varchar(60) NOT NULL,
  `courseCode` varchar(20) NOT NULL,
  `Course` varchar(60) NOT NULL,
  `Subject` varchar(60) NOT NULL,
  `Unit` int(11) NOT NULL,
  `Room` varchar(60) NOT NULL,
  `Day` varchar(60) NOT NULL,
  `StartTime` time NOT NULL,
  `EndTime` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_section`
--

CREATE TABLE `tbl_section` (
  `sectionID` int(11) NOT NULL,
  `sectionCode` varchar(60) NOT NULL,
  `sectionDesc` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_section`
--

INSERT INTO `tbl_section` (`sectionID`, `sectionCode`, `sectionDesc`) VALUES
(1, 'A', 'A'),
(2, 'B', 'B'),
(3, 'C', 'C'),
(4, 'D', 'D');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_subject`
--

CREATE TABLE `tbl_subject` (
  `subjectID` int(11) NOT NULL,
  `subjectCode` varchar(60) NOT NULL,
  `subjectDesc` varchar(60) NOT NULL,
  `unit` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_subject`
--

INSERT INTO `tbl_subject` (`subjectID`, `subjectCode`, `subjectDesc`, `unit`) VALUES
(1, 'CC105', 'Information Management', 3),
(3, 'CC103', 'Introducing of Information', 3);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_timein`
--

CREATE TABLE `tbl_timein` (
  `timeID` int(11) NOT NULL,
  `employeeCode` varchar(60) NOT NULL,
  `fullname` varchar(100) NOT NULL,
  `Department` varchar(150) NOT NULL,
  `Day` varchar(60) NOT NULL,
  `Month` varchar(60) NOT NULL,
  `year` varchar(60) NOT NULL,
  `Date` date NOT NULL,
  `TimeIn` time NOT NULL,
  `TimeOut` time NOT NULL,
  `totalHours` int(11) NOT NULL,
  `LateHr` time NOT NULL,
  `Absent` int(11) NOT NULL,
  `Awol` int(11) NOT NULL,
  `Overtime` time NOT NULL,
  `Undetime` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_year`
--

CREATE TABLE `tbl_year` (
  `yearID` int(11) NOT NULL,
  `yearCode` varchar(60) NOT NULL,
  `yearDesc` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_year`
--

INSERT INTO `tbl_year` (`yearID`, `yearCode`, `yearDesc`) VALUES
(1, '1', '1st year'),
(2, '2', '2nd year'),
(3, '3', '3rd year'),
(4, '4', '4th year'),
(5, '5', '5th year');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`adminID`);

--
-- Indexes for table `tbl_benefits`
--
ALTER TABLE `tbl_benefits`
  ADD PRIMARY KEY (`govID`);

--
-- Indexes for table `tbl_course`
--
ALTER TABLE `tbl_course`
  ADD PRIMARY KEY (`courseID`);

--
-- Indexes for table `tbl_department`
--
ALTER TABLE `tbl_department`
  ADD PRIMARY KEY (`departmentID`);

--
-- Indexes for table `tbl_employee`
--
ALTER TABLE `tbl_employee`
  ADD PRIMARY KEY (`employeeID`);

--
-- Indexes for table `tbl_leave`
--
ALTER TABLE `tbl_leave`
  ADD PRIMARY KEY (`leaveID`);

--
-- Indexes for table `tbl_personalinfo`
--
ALTER TABLE `tbl_personalinfo`
  ADD PRIMARY KEY (`personalID`);

--
-- Indexes for table `tbl_room`
--
ALTER TABLE `tbl_room`
  ADD PRIMARY KEY (`roomID`);

--
-- Indexes for table `tbl_salary`
--
ALTER TABLE `tbl_salary`
  ADD PRIMARY KEY (`salaryID`);

--
-- Indexes for table `tbl_schedule`
--
ALTER TABLE `tbl_schedule`
  ADD PRIMARY KEY (`scheduleID`);

--
-- Indexes for table `tbl_section`
--
ALTER TABLE `tbl_section`
  ADD PRIMARY KEY (`sectionID`);

--
-- Indexes for table `tbl_subject`
--
ALTER TABLE `tbl_subject`
  ADD PRIMARY KEY (`subjectID`);

--
-- Indexes for table `tbl_timein`
--
ALTER TABLE `tbl_timein`
  ADD PRIMARY KEY (`timeID`);

--
-- Indexes for table `tbl_year`
--
ALTER TABLE `tbl_year`
  ADD PRIMARY KEY (`yearID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  MODIFY `adminID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `tbl_benefits`
--
ALTER TABLE `tbl_benefits`
  MODIFY `govID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=62;

--
-- AUTO_INCREMENT for table `tbl_course`
--
ALTER TABLE `tbl_course`
  MODIFY `courseID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `tbl_department`
--
ALTER TABLE `tbl_department`
  MODIFY `departmentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tbl_employee`
--
ALTER TABLE `tbl_employee`
  MODIFY `employeeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=105;

--
-- AUTO_INCREMENT for table `tbl_leave`
--
ALTER TABLE `tbl_leave`
  MODIFY `leaveID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=149;

--
-- AUTO_INCREMENT for table `tbl_personalinfo`
--
ALTER TABLE `tbl_personalinfo`
  MODIFY `personalID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=126;

--
-- AUTO_INCREMENT for table `tbl_room`
--
ALTER TABLE `tbl_room`
  MODIFY `roomID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tbl_salary`
--
ALTER TABLE `tbl_salary`
  MODIFY `salaryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `tbl_schedule`
--
ALTER TABLE `tbl_schedule`
  MODIFY `scheduleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=69;

--
-- AUTO_INCREMENT for table `tbl_section`
--
ALTER TABLE `tbl_section`
  MODIFY `sectionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbl_subject`
--
ALTER TABLE `tbl_subject`
  MODIFY `subjectID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl_timein`
--
ALTER TABLE `tbl_timein`
  MODIFY `timeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=80;

--
-- AUTO_INCREMENT for table `tbl_year`
--
ALTER TABLE `tbl_year`
  MODIFY `yearID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
