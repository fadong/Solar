-- //TODO - Table Creation Script 계속작성

-- Instrument Table
-- Jaekyoon, Lee(2014-02-07)
drop table D_Instrument;
create table D_Instrument (
	ID int,
	NAME varchar2(50),
	INSTYPE number(2),
	ISIN varchar2(12),
	EXTRN_ID1 varchar2(16),
	EXTRN_ID2 varchar2(16),
	ISSUEDAY date,
	STARTDAY date,
	ENDDAY date,
	EXP_PERIOD_COUNT number(4),
	EXP_PERIOD_UNIT NUMBER(1),
	CURRENCY int,
	CALLABLE number(1),
	PUTABLE number(1),
	ISDIGITAL number(1),
	ISOTC number(1),
	ISGENERIC number(1),
	VMODEL int,
	CATAG_ID int,
	CONTRSIZE float,
	CREATED_TIME date,
	CREATED_USER int,
	UPDATED_TIME date,
	UPDATED_USER int,
	constraint D_Instrument_PK primary key(ID)
);

-- Leg Table
-- Jaekyoon, Lee(2014-02-07)
drop table D_Leg;
create table D_Leg (
	ID int,
	CREATED_TIME date,
	CREATED_USER int,
	UPDATED_TIME date,
	UPDATED_USER int,
	constraint S_Leg_PK primary key (ID)
);

-- CashFlow Table
-- Jaekyoon, Lee(2014-02-07)
drop table D_CashFlow;
create table D_CashFlow (
	ID int,
	CREATED_TIME date,
	CREATED_USER int,
	UPDATED_TIME date,
	UPDATED_USER int,
	constraint D_CashFlow_PK primary key (ID)
);

-- Reset Table
-- Jaekyoon, Lee (2014-02-07)
drop table D_Reset;
create table D_Reset (
	ID int,
	CREATED_TIME date,
	CREATED_USER int,
	UPDATED_TIME date,
	UPDATED_USER int,
	constraint D_Reset_PK primary key (ID)
);

-- AddInfo Table
-- Jaekyoon, Lee (2014-02-07)
drop table D_AddInfo;
create table D_AddInfo (
	ID int,
	CREATED_TIME date,
	CREATED_USER int,
	UPDATED_TIME date,
	UPDATED_USER int,
	constraint D_AddInfo_PK primary key (ID)
);

-- AddInfoSpec Table
-- Jaekyoon, Lee (2014-02-07)
drop table D_AddInfoSpec;
create table D_AddInfoSpec (
	ID int,
	CREATED_TIME date,
	CREATED_USER int,
	UPDATED_TIME date,
	UPDATED_USER int,
	constraint D_AddInfoSpec_PK primary key (ID)
);

-- Trade Table
-- Jaekyoon, Lee (2014-02-07)
drop table D_Trade;
create table D_Trade (
	ID int,
	CREATED_TIME date,
	CREATED_USER int,
	UPDATED_TIME date,
	UPDATED_USER int,
	constraint D_Trade_PK primary key (ID)
);

-- HistPrices Table
-- Jaekyoon, Lee (2014-02-07)
drop table D_HistPrices;
create table D_HistPrices (
	ID int,
	OPrice float,
	HPrice float,
	LPrice float,
	CPrice float,
	Settle float,
	CREATED_TIME date,
	CREATED_USER int,
	UPDATED_TIME date,
	UPDATED_USER int,
	constraint D_Price_PK primary key (ID)
);

-- Portfolio Table
-- Jaekyoon, Lee (2014-02-07)
drop table C_Portfolio;
create table C_Portfolio (
	ID int,
	NAME varchar2(30),
	ISCOMPOUND number(1),
	BASECURRENCY int,
	PRF_TYPE NUMBER(1),       -- Portfolio Type
	OWNER_TYPE NUMBER(1),     -- 
	OWNER_ID int,
	CREATED_TIME date,
	CREATED_USER int,
	UPDATED_TIME date,
	UPDATED_USER int,
	constraint C_Portfolio_PK primary key (ID)
);

-- Link Table
-- Jaekyoon, Lee (2014-02-07)
drop table C_Link;
create table C_Link (
	ID int,
	LinkType number(2),
	Parent_ID int,
	Child_ID int,
	CREATED_TIME date,
	CREATED_USER int,
	UPDATED_TIME date,
	UPDATED_USER int,
	constraint C_Link_PK primary key (ID)
);

-- Log Table
-- Jaekyoon, Lee (2014-02-07)
drop table S_Log;
create table S_Log (
	ID int,
	CREATED_TIME date,
	CREATED_USER int,
	UPDATED_TIME date,
	UPDATED_USER int,
	constraint S_Log_PK primary key (ID)
);