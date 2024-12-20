	insert into PHONG values 
('P101', N'Trống',1, 'LP01'), 
('P102', N'Trống',1, 'LP01'),
('P103', N'Trống',1, 'LP01'),
('P104', N'Trống',1, 'LP01'),
('P105', N'Trống',1, 'LP01'),
('P106', N'Trống',1, 'LP01'),
('P107', N'Trống',1, 'LP01'),
('P108', N'Trống',1, 'LP01'),
('P109', N'Trống',1, 'LP01'),
('P110', N'Trống',1, 'LP01'),
('P201', N'Trống',2, 'LP01'),
('P202', N'Trống',2, 'LP01'),
('P203', N'Trống',2, 'LP01'),
('P204', N'Trống',2, 'LP01'),
('P205', N'Trống',2, 'LP01'),
('P206', N'Trống',2, 'LP02'),
('P207', N'Trống',2, 'LP02'),
('P208', N'Trống',2, 'LP02'),
('P209', N'Trống',2, 'LP02'),
('P301', N'Trống',3, 'LP02'),
('P302', N'Trống',3, 'LP02'),
('P303', N'Trống',3, 'LP02'),
('P304', N'Trống',3, 'LP02'),
('P305', N'Trống',3, 'LP02'),
('P306', N'Trống',3, 'LP02'),
('P307', N'Trống',3, 'LP02'),
('P308', N'Trống',3, 'LP02'),
('P401', N'Trống',4, 'LP02'),
('P402', N'Trống',4, 'LP03'),
('P403', N'Trống',4, 'LP03'),
('P404', N'Trống',4, 'LP03'),
('P405', N'Trống',4, 'LP03'),
('P406', N'Trống',4, 'LP03');
	


INSERT INTO LOAIPHONG (MaLPH, TenLPH, Gia, Ghichu, Soluong)
VALUES ('LP01', 'A', 150000, N'Phòng loại A', 20),
       ('LP02', 'B', 170000, N'Phòng loại B', 15),
       ('LP03', 'C', 200000, N'Phòng loại C', 10);


INSERT INTO LOAIDICHVU VALUES('LDV1',N'Giặt ủi quần áo',N'<= 2kg: 40k, >2kg phụ thu thêm 25k/kg.','40000');
INSERT INTO LOAIDICHVU VALUES('LDV2',N'Cho thuê xe máy',N'Chi phí thuê: 150k/ngày.','150000');
INSERT INTO LOAIDICHVU VALUES('LDV3',N'Thu đổi ngoại tệ',N'Tối đa 10.000.000vnđ, thu phí 2%.','1000000');
INSERT INTO LOAIDICHVU VALUES('LDV4',N'Đón khách',N'Miễn phí < 5km, > 6 km phụ thu 10.000/km','10000');
INSERT INTO LOAIDICHVU VALUES('LDV5',N'Buffet sáng',N'Khung giờ phụ vụ: 6h30-9h30 mỗi ngày.','50000');


INSERT INTO NHANVIEN VALUES('NV1', N'Trần Quang Đạt', N'Nam', '22520236', '225202363@gmail.com', N'Thủ Đức', '05-09-2024 00:00:00', '5000000')
INSERT INTO NHANVIEN VALUES('NV2', N'Văn Quốc Khánh', N'Nam', '22520658', '22520658@gmail.com', N'Thủ Đức', '10-04-2024 00:00:00', '5000000')
INSERT INTO NHANVIEN VALUES('NV3', N'Lê Huỳnh Giang', N'Nam', '22520356', '22520356@gmail.com', N'Thủ Đức', '10-04-2024 00:00:00', '5000000')
INSERT INTO NHANVIEN VALUES('NV4', N'Vũ Quang Dũng', N'Nam', '22520294', '22520294@gmail.com', N'Thủ Đức', '10-04-2024 00:00:00', '5000000')

