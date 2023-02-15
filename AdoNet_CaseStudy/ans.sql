create database abcBankDb


create table Tbl_AccountOpen
(AccountNumber smallint identity(1,1) primary key,
AccountName varchar(50), Address varchar(100), OpeningDate datetime, Balance money)

create table Tbl_Transactions
(TransactionId smallint identity(1,1) primary key,
AccountNumber smallint foreign key references Tbl_AccountOpen(AccountNumber),
TransactionDate datetime,
TransactionType char,
TransactionAmount money)

--=======Account open procedurecreate procedure Proc_AccountOpen @AccountName varchar(50), @Address varchar(100), @DepositeAmount smallint,@AccountNumber smallint outasbegin	begin try	begin transaction		insert into  Tbl_AccountOpen values(@AccountName, @Address, getDate(),@DepositeAmount)		set @AccountNumber = SCOPE_IDENTITY()		insert into Tbl_Transactions values(@AccountNumber, getDate(), 'D', @DepositeAmount)--		set @TransactionId = SCOPE_IDENTITY()	commit transaction	end try	begin catch		rollback transaction		print error_message()	end catchend


declare
	@accNumber smallint
	begin 
		execute Proc_AccountOpen @AccountName = 'Rahul', @Address = 'kolkata', @DepositeAmount='10000',
		@AccountNumber = @accNumber out
		print 'Account no. is :' + cast(@accNumber as varchar)
	end

--=======transaction procedure
create procedure Proc_Transactions @AccountNumber smallint, @TransactionType char,
@TransactionAmount smallint, @TransactionId smallint out
as
declare @bal smallint
	begin
		begin try
			begin transaction
			insert into Tbl_Transactions values(@AccountNumber, getDate(), @TransactionType, @TransactionAmount)
			set @TransactionId = SCOPE_IDENTITY()
			--select * from Tbl_AccountOpen where AccountNumber = @AccountNumber
			--IF @TransactionAmount > (select Balance from Tbl_AccountOpen where AccountNumber = @AccountNumber)
			
			select @bal=balance from Tbl_AccountOpen where AccountNumber = @AccountNumber
			IF @TransactionType='D'
				begin
				update Tbl_AccountOpen
					set Balance = @bal + @TransactionAmount where AccountNumber = @AccountNumber
				end
			ELSE IF @TransactionType = 'W'
				IF (@bal - @TransactionAmount) > 0
					begin
					update Tbl_AccountOpen
						set Balance = @bal - @TransactionAmount where AccountNumber = @AccountNumber
					end
				ELSE 
					Raiserror(15600, -1, -1, 'Proc_Transsctions')
			ELSE
				begin
					Raiserror(15600, -1, -1, 'Proc_Transsctions')
				end
			commit transaction		end try		begin catch			rollback transaction			print error_message()		end catch
	end


declare 
	@transId smallint
	begin
		execute Proc_Transactions @AccountNumber = '1', @TransactionType = 'W', @TransactionAmount='1100',
		@TransactionId = @transId out
		print 'Transaction id :' + cast(@transId as varchar)
	end

	
--delete from Tbl_AccountOpen
select * from Tbl_AccountOpen
select * from tbl_transactions
sp_help tbl_Accountopen
sp_help tbl_transactions

select * from Departments
select * from Employees

