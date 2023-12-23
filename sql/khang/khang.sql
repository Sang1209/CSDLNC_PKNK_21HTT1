use csc12002_21clc10_n10
GO
CREATE OR ALTER PROCEDURE AddMedicine
    @id varchar(5),
    @name varchar(20),
    @price float
AS
BEGIN
    INSERT INTO medicine (id, name, price) VALUES (@id, @name, @price)
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
    @newName varchar(20),
    @newPrice float
AS
BEGIN
    UPDATE medicine SET name = @newName, price = @newPrice WHERE id = @id
END
GO

CREATE OR ALTER PROCEDURE ViewMedicineList
AS
BEGIN
    SELECT * FROM medicine
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
    @contraindicatedNote varchar(100)
AS
BEGIN
    INSERT INTO patient_profile (id, name, birth, phone, email, address, gender, bill, paid, contraindicated_note)
    VALUES (@id, @name, @birth, @phone, @email, @address, @gender, @bill, @paid, @contraindicatedNote)
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
    @newContraindicatedNote varchar(100)
AS
BEGIN
    UPDATE patient_profile
    SET name = @newName, birth = @newBirth, phone = @newPhone, email = @newEmail, 
        address = @newAddress, gender = @newGender, bill = @newBill, paid = @newPaid, 
        contraindicated_note = @newContraindicatedNote
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

CREATE OR ALTER PROCEDURE ViewAppointment
    @patientID int
AS
BEGIN
    SELECT *
    FROM schedule
    WHERE patient = @patientID
END
GO

CREATE OR ALTER PROCEDURE DeleteAppointment
    @patientID int,
    @date date,
    @shiftID smallint
AS
BEGIN
    DELETE FROM schedule
    WHERE date = @date AND shift_id = @shiftID AND patient = @patientID
END
GO
