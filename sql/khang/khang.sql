CREATE OR ALTER PROCEDURE AddClinic
    @id smallint,
    @address varchar(50)
AS
BEGIN
    INSERT INTO department (id, address) VALUES (@id, @address)
END
GO

CREATE OR ALTER PROCEDURE DeleteClinic
    @id smallint
AS
BEGIN
    DELETE FROM department WHERE id = @id
END
GO

CREATE OR ALTER PROCEDURE UpdateClinic
    @id smallint,
    @newAddress varchar(50)
AS
BEGIN
    UPDATE department SET address = @newAddress WHERE id = @id
END
GO

CREATE OR ALTER PROCEDURE AddPatient
    @id int,
    @name varchar(20),
    @birth date,
    @phone varchar(12),
    @email varchar(50),
    @address varchar(50),
    @gender bit,
    @bill float,
    @paid float,
    @condition varchar(100),
    @contraindicatedNote varchar(100)
AS
BEGIN
    INSERT INTO patient_profile (id, name, birth, phone, email, address, gender, bill, paid, overall_condition, contraindicated_note)
    VALUES (@id, @name, @birth, @phone, @email, @address, @gender, @bill, @paid, @condition, @contraindicatedNote)
END
GO

CREATE OR ALTER PROCEDURE UpdatePatient
    @id int,
    @newName varchar(20),
    @newBirth date,
    @newPhone varchar(12),
    @newEmail varchar(50),
    @newAddress varchar(50),
    @newGender bit,
    @newBill float,
    @newPaid float,
    @newCondition varchar(100),
    @newContraindicatedNote varchar(100)
AS
BEGIN
    UPDATE patient_profile
    SET name = @newName, birth = @newBirth, phone = @newPhone, email = @newEmail, 
        address = @newAddress, gender = @newGender, bill = @newBill, paid = @newPaid, 
        overall_condition = @newCondition, contraindicated_note = @newContraindicatedNote
    WHERE id = @id
END
GO

CREATE OR ALTER PROCEDURE AddPatientAllergy
    @patientID int,
    @medicine varchar(5)
AS
BEGIN
    INSERT INTO contraindicated (patient, medicine) VALUES (@patientID, @medicine)
END
GO

CREATE OR ALTER PROCEDURE DeletePatientAllergy
    @patientID int,
    @medicine varchar(5)
AS
BEGIN
    DELETE FROM contraindicated WHERE patient = @patientID AND medicine = @medicine
END
GO

CREATE OR ALTER PROCEDURE UpdatePatientAllergy
    @patientID int,
    @oldMedicine varchar(5),
    @newMedicine varchar(5)
AS
BEGIN
    UPDATE contraindicated SET medicine = @newMedicine WHERE patient = @patientID AND medicine = @oldMedicine
END
GO

--CREATE OR ALTER PROCEDURE ViewAppointment
--	@dentist char(10)
--AS
--BEGIN
--	SET STATISTICS IO, TIME ON
--    SELECT * FROM schedule WHERE datediff(d,date,getdate())<=0 and dentist = @dentist
--	SET STATISTICS IO, TIME off
--END
--GO

--CREATE OR ALTER PROCEDURE DeleteAppointment
--    @patientID int,
--    @date date,
--    @shiftID smallint
--AS
--BEGIN
--    DELETE FROM schedule WHERE date = @date AND shift_id = @shiftID and patient = @patientID
--END
--GO

CREATE OR ALTER PROCEDURE AddMedicine
    @id varchar(5),
    @name varchar(20)
AS
BEGIN
    INSERT INTO medicine (id, name) VALUES (@id, @name)
END
GO

CREATE OR ALTER PROCEDURE DeleteMedicine
    @id varchar(5)
AS
BEGIN
    DELETE FROM medicine WHERE id = @id
END
GO

CREATE OR ALTER PROCEDURE UpdateMedicine
    @id varchar(5),
    @newName varchar(20)
AS
BEGIN
    UPDATE medicine SET name = @newName WHERE id = @id
END
GO

CREATE OR ALTER PROCEDURE ViewMedicineList
AS
BEGIN
    SELECT * FROM medicine order by name
END
GO
exec ViewMedicineList
