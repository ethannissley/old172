﻿<?xml version="1.0" encoding="utf-8"?>
<Schema Namespace="CommunityAssist2017Model" Alias="Self" annotation:UseStrongSpatialTypes="false" xmlns:annotation="http://schemas.microsoft.com/ado/2009/02/edm/annotation" xmlns:customannotation="http://schemas.microsoft.com/ado/2013/11/edm/customannotation" xmlns="http://schemas.microsoft.com/ado/2009/11/edm">
  <EntityType Name="BusinessRule">
    <Key>
      <PropertyRef Name="BusinessRuleKey" />
    </Key>
    <Property Name="BusinessRuleKey" Type="Int32" Nullable="false" annotation:StoreGeneratedPattern="Identity" />
    <Property Name="BusinessRuleText" Type="String" MaxLength="255" FixedLength="false" Unicode="true" />
  </EntityType>
  <EntityType Name="Donation">
    <Key>
      <PropertyRef Name="DonationKey" />
    </Key>
    <Property Name="DonationKey" Type="Int32" Nullable="false" annotation:StoreGeneratedPattern="Identity" />
    <Property Name="PersonKey" Type="Int32" />
    <Property Name="DonationDate" Type="DateTime" Precision="3" />
    <Property Name="DonationAmount" Type="Decimal" Precision="10" Scale="2" Nullable="false" />
    <Property Name="DonationConfirmationCode" Type="Guid" />
    <NavigationProperty Name="Person" Relationship="Self.FK__Donation__Person__3A81B327" FromRole="Donation" ToRole="Person" />
  </EntityType>
  <EntityType Name="Employee">
    <Key>
      <PropertyRef Name="EmployeeKey" />
    </Key>
    <Property Name="EmployeeKey" Type="Int32" Nullable="false" annotation:StoreGeneratedPattern="Identity" />
    <Property Name="PersonKey" Type="Int32" />
    <Property Name="EmployeeDateHired" Type="DateTime" Nullable="false" Precision="0" />
    <NavigationProperty Name="Person" Relationship="Self.FK__Employee__Person__300424B4" FromRole="Employee" ToRole="Person" />
    <NavigationProperty Name="EmployeePositions" Relationship="Self.FK__EmployeeP__Emplo__33D4B598" FromRole="Employee" ToRole="EmployeePosition" />
    <NavigationProperty Name="GrantApplicationReviews" Relationship="Self.FK__GrantAppl__Emplo__48CFD27E" FromRole="Employee" ToRole="GrantApplicationReview" />
  </EntityType>
  <EntityType Name="EmployeePosition">
    <Key>
      <PropertyRef Name="PositionKey" />
      <PropertyRef Name="EmployeeKey" />
    </Key>
    <Property Name="PositionKey" Type="Int32" Nullable="false" />
    <Property Name="EmployeeKey" Type="Int32" Nullable="false" />
    <Property Name="EmployeePositionDateAdded" Type="DateTime" Precision="3" />
    <NavigationProperty Name="Employee" Relationship="Self.FK__EmployeeP__Emplo__33D4B598" FromRole="EmployeePosition" ToRole="Employee" />
    <NavigationProperty Name="Position" Relationship="Self.FK__EmployeeP__Posit__32E0915F" FromRole="EmployeePosition" ToRole="Position" />
  </EntityType>
  <EntityType Name="GrantApplication">
    <Key>
      <PropertyRef Name="GrantApplicationKey" />
    </Key>
    <Property Name="GrantApplicationKey" Type="Int32" Nullable="false" annotation:StoreGeneratedPattern="Identity" />
    <Property Name="PersonKey" Type="Int32" />
    <Property Name="GrantAppicationDate" Type="DateTime" Precision="3" />
    <Property Name="GrantTypeKey" Type="Int32" />
    <Property Name="GrantApplicationRequestAmount" Type="Decimal" Precision="8" Scale="2" Nullable="false" />
    <Property Name="GrantApplicationReason" Type="String" MaxLength="255" FixedLength="false" Unicode="true" Nullable="false" />
    <Property Name="GrantApplicationStatusKey" Type="Int32" />
    <Property Name="GrantApplicationAllocationAmount" Type="Decimal" Precision="8" Scale="2" />
    <NavigationProperty Name="GrantType" Relationship="Self.FK__GrantAppl__Grant__4316F928" FromRole="GrantApplication" ToRole="GrantType" />
    <NavigationProperty Name="GrantApplicationStatu" Relationship="Self.FK__GrantAppl__Grant__440B1D61" FromRole="GrantApplication" ToRole="GrantApplicationStatus" />
    <NavigationProperty Name="GrantApplicationReviews" Relationship="Self.FK__GrantAppl__Grant__47DBAE45" FromRole="GrantApplication" ToRole="GrantApplicationReview" />
    <NavigationProperty Name="Person" Relationship="Self.FK__GrantAppl__Perso__412EB0B6" FromRole="GrantApplication" ToRole="Person" />
  </EntityType>
  <EntityType Name="GrantApplicationReview">
    <Key>
      <PropertyRef Name="GrantApplicationReviewKey" />
    </Key>
    <Property Name="GrantApplicationReviewKey" Type="Int32" Nullable="false" annotation:StoreGeneratedPattern="Identity" />
    <Property Name="GrantApplicationKey" Type="Int32" />
    <Property Name="EmployeeKey" Type="Int32" />
    <Property Name="GrantApplicationReviewDate" Type="DateTime" Precision="3" />
    <Property Name="GrantApplicationReviewNotes" Type="String" MaxLength="255" FixedLength="false" Unicode="true" Nullable="false" />
    <NavigationProperty Name="Employee" Relationship="Self.FK__GrantAppl__Emplo__48CFD27E" FromRole="GrantApplicationReview" ToRole="Employee" />
    <NavigationProperty Name="GrantApplication" Relationship="Self.FK__GrantAppl__Grant__47DBAE45" FromRole="GrantApplicationReview" ToRole="GrantApplication" />
  </EntityType>
  <EntityType Name="GrantApplicationStatu">
    <Key>
      <PropertyRef Name="GrantApplicationStatusKey" />
    </Key>
    <Property Name="GrantApplicationStatusKey" Type="Int32" Nullable="false" />
    <Property Name="GrantApplicationStatusTerm" Type="String" MaxLength="20" FixedLength="false" Unicode="true" Nullable="false" />
    <NavigationProperty Name="GrantApplications" Relationship="Self.FK__GrantAppl__Grant__440B1D61" FromRole="GrantApplicationStatus" ToRole="GrantApplication" />
  </EntityType>
  <EntityType Name="GrantType">
    <Key>
      <PropertyRef Name="GrantTypeKey" />
    </Key>
    <Property Name="GrantTypeKey" Type="Int32" Nullable="false" annotation:StoreGeneratedPattern="Identity" />
    <Property Name="GrantTypeName" Type="String" MaxLength="255" FixedLength="false" Unicode="true" Nullable="false" />
    <Property Name="GrantTypeDescription" Type="String" MaxLength="255" FixedLength="false" Unicode="true" />
    <Property Name="GrantTypemaximum" Type="Decimal" Precision="8" Scale="2" Nullable="false" />
    <Property Name="GrantTypeLifetimeMaximum" Type="Decimal" Precision="10" Scale="2" Nullable="false" />
    <Property Name="GrantTypeDateEntered" Type="DateTime" Precision="3" />
    <NavigationProperty Name="GrantApplications" Relationship="Self.FK__GrantAppl__Grant__4316F928" FromRole="GrantType" ToRole="GrantApplication" />
  </EntityType>
  <EntityType Name="LoginHistory">
    <Key>
      <PropertyRef Name="loginHistoryKey" />
    </Key>
    <Property Name="loginHistoryKey" Type="Int32" Nullable="false" annotation:StoreGeneratedPattern="Identity" />
    <Property Name="PersonKey" Type="Int32" />
    <Property Name="LoginHistoryTimeStamp" Type="DateTime" Precision="3" />
    <NavigationProperty Name="Person" Relationship="Self.FK__LoginHist__Perso__4CA06362" FromRole="LoginHistory" ToRole="Person" />
  </EntityType>
  <EntityType Name="Person">
    <Key>
      <PropertyRef Name="PersonKey" />
    </Key>
    <Property Name="PersonKey" Type="Int32" Nullable="false" annotation:StoreGeneratedPattern="Identity" />
    <Property Name="PersonLastName" Type="String" MaxLength="255" FixedLength="false" Unicode="true" Nullable="false" />
    <Property Name="PersonFirstName" Type="String" MaxLength="255" FixedLength="false" Unicode="true" />
    <Property Name="PersonEmail" Type="String" MaxLength="255" FixedLength="false" Unicode="true" Nullable="false" />
    <Property Name="PersonPrimaryPhone" Type="String" MaxLength="10" FixedLength="true" Unicode="true" />
    <Property Name="PersonPassword" Type="Binary" MaxLength="500" FixedLength="false" />
    <Property Name="PersonPassSeed" Type="Int32" />
    <Property Name="PersonDateAdded" Type="DateTime" Precision="3" />
    <NavigationProperty Name="Donations" Relationship="Self.FK__Donation__Person__3A81B327" FromRole="Person" ToRole="Donation" />
    <NavigationProperty Name="Employees" Relationship="Self.FK__Employee__Person__300424B4" FromRole="Person" ToRole="Employee" />
    <NavigationProperty Name="GrantApplications" Relationship="Self.FK__GrantAppl__Perso__412EB0B6" FromRole="Person" ToRole="GrantApplication" />
    <NavigationProperty Name="LoginHistories" Relationship="Self.FK__LoginHist__Perso__4CA06362" FromRole="Person" ToRole="LoginHistory" />
    <NavigationProperty Name="PersonAddresses" Relationship="Self.FK__PersonAdd__Perso__276EDEB3" FromRole="Person" ToRole="PersonAddress" />
  </EntityType>
  <EntityType Name="PersonAddress">
    <Key>
      <PropertyRef Name="PersonAddressKey" />
    </Key>
    <Property Name="PersonAddressKey" Type="Int32" Nullable="false" annotation:StoreGeneratedPattern="Identity" />
    <Property Name="PersonKey" Type="Int32" />
    <Property Name="PersonAddressApt" Type="String" MaxLength="20" FixedLength="false" Unicode="true" />
    <Property Name="PersonAddressStreet" Type="String" MaxLength="255" FixedLength="false" Unicode="true" Nullable="false" />
    <Property Name="PersonAddressCity" Type="String" MaxLength="255" FixedLength="false" Unicode="true" />
    <Property Name="PersonAddressState" Type="String" MaxLength="2" FixedLength="true" Unicode="true" />
    <Property Name="PersonAddressPostal" Type="String" MaxLength="12" FixedLength="true" Unicode="true" Nullable="false" />
    <Property Name="PersonAddressDateAdded" Type="DateTime" Precision="3" />
    <NavigationProperty Name="Person" Relationship="Self.FK__PersonAdd__Perso__276EDEB3" FromRole="PersonAddress" ToRole="Person" />
  </EntityType>
  <EntityType Name="Position">
    <Key>
      <PropertyRef Name="PositionKey" />
    </Key>
    <Property Name="PositionKey" Type="Int32" Nullable="false" annotation:StoreGeneratedPattern="Identity" />
    <Property Name="PositionName" Type="String" MaxLength="255" FixedLength="false" Unicode="true" Nullable="false" />
    <Property Name="PositionDescription" Type="String" MaxLength="255" FixedLength="false" Unicode="true" />
    <Property Name="PositionDateAdded" Type="DateTime" Precision="3" />
    <NavigationProperty Name="EmployeePositions" Relationship="Self.FK__EmployeeP__Posit__32E0915F" FromRole="Position" ToRole="EmployeePosition" />
  </EntityType>
  <Association Name="FK__Donation__Person__3A81B327">
    <End Role="Person" Type="Self.Person" Multiplicity="0..1" />
    <End Role="Donation" Type="Self.Donation" Multiplicity="*" />
    <ReferentialConstraint>
      <Principal Role="Person">
        <PropertyRef Name="PersonKey" />
      </Principal>
      <Dependent Role="Donation">
        <PropertyRef Name="PersonKey" />
      </Dependent>
    </ReferentialConstraint>
  </Association>
  <Association Name="FK__Employee__Person__300424B4">
    <End Role="Person" Type="Self.Person" Multiplicity="0..1" />
    <End Role="Employee" Type="Self.Employee" Multiplicity="*" />
    <ReferentialConstraint>
      <Principal Role="Person">
        <PropertyRef Name="PersonKey" />
      </Principal>
      <Dependent Role="Employee">
        <PropertyRef Name="PersonKey" />
      </Dependent>
    </ReferentialConstraint>
  </Association>
  <Association Name="FK__EmployeeP__Emplo__33D4B598">
    <End Role="Employee" Type="Self.Employee" Multiplicity="1" />
    <End Role="EmployeePosition" Type="Self.EmployeePosition" Multiplicity="*" />
    <ReferentialConstraint>
      <Principal Role="Employee">
        <PropertyRef Name="EmployeeKey" />
      </Principal>
      <Dependent Role="EmployeePosition">
        <PropertyRef Name="EmployeeKey" />
      </Dependent>
    </ReferentialConstraint>
  </Association>
  <Association Name="FK__GrantAppl__Emplo__48CFD27E">
    <End Role="Employee" Type="Self.Employee" Multiplicity="0..1" />
    <End Role="GrantApplicationReview" Type="Self.GrantApplicationReview" Multiplicity="*" />
    <ReferentialConstraint>
      <Principal Role="Employee">
        <PropertyRef Name="EmployeeKey" />
      </Principal>
      <Dependent Role="GrantApplicationReview">
        <PropertyRef Name="EmployeeKey" />
      </Dependent>
    </ReferentialConstraint>
  </Association>
  <Association Name="FK__EmployeeP__Posit__32E0915F">
    <End Role="Position" Type="Self.Position" Multiplicity="1" />
    <End Role="EmployeePosition" Type="Self.EmployeePosition" Multiplicity="*" />
    <ReferentialConstraint>
      <Principal Role="Position">
        <PropertyRef Name="PositionKey" />
      </Principal>
      <Dependent Role="EmployeePosition">
        <PropertyRef Name="PositionKey" />
      </Dependent>
    </ReferentialConstraint>
  </Association>
  <Association Name="FK__GrantAppl__Grant__4316F928">
    <End Role="GrantType" Type="Self.GrantType" Multiplicity="0..1" />
    <End Role="GrantApplication" Type="Self.GrantApplication" Multiplicity="*" />
    <ReferentialConstraint>
      <Principal Role="GrantType">
        <PropertyRef Name="GrantTypeKey" />
      </Principal>
      <Dependent Role="GrantApplication">
        <PropertyRef Name="GrantTypeKey" />
      </Dependent>
    </ReferentialConstraint>
  </Association>
  <Association Name="FK__GrantAppl__Grant__440B1D61">
    <End Role="GrantApplicationStatus" Type="Self.GrantApplicationStatu" Multiplicity="0..1" />
    <End Role="GrantApplication" Type="Self.GrantApplication" Multiplicity="*" />
    <ReferentialConstraint>
      <Principal Role="GrantApplicationStatus">
        <PropertyRef Name="GrantApplicationStatusKey" />
      </Principal>
      <Dependent Role="GrantApplication">
        <PropertyRef Name="GrantApplicationStatusKey" />
      </Dependent>
    </ReferentialConstraint>
  </Association>
  <Association Name="FK__GrantAppl__Grant__47DBAE45">
    <End Role="GrantApplication" Type="Self.GrantApplication" Multiplicity="0..1" />
    <End Role="GrantApplicationReview" Type="Self.GrantApplicationReview" Multiplicity="*" />
    <ReferentialConstraint>
      <Principal Role="GrantApplication">
        <PropertyRef Name="GrantApplicationKey" />
      </Principal>
      <Dependent Role="GrantApplicationReview">
        <PropertyRef Name="GrantApplicationKey" />
      </Dependent>
    </ReferentialConstraint>
  </Association>
  <Association Name="FK__GrantAppl__Perso__412EB0B6">
    <End Role="Person" Type="Self.Person" Multiplicity="0..1" />
    <End Role="GrantApplication" Type="Self.GrantApplication" Multiplicity="*" />
    <ReferentialConstraint>
      <Principal Role="Person">
        <PropertyRef Name="PersonKey" />
      </Principal>
      <Dependent Role="GrantApplication">
        <PropertyRef Name="PersonKey" />
      </Dependent>
    </ReferentialConstraint>
  </Association>
  <Association Name="FK__LoginHist__Perso__4CA06362">
    <End Role="Person" Type="Self.Person" Multiplicity="0..1" />
    <End Role="LoginHistory" Type="Self.LoginHistory" Multiplicity="*" />
    <ReferentialConstraint>
      <Principal Role="Person">
        <PropertyRef Name="PersonKey" />
      </Principal>
      <Dependent Role="LoginHistory">
        <PropertyRef Name="PersonKey" />
      </Dependent>
    </ReferentialConstraint>
  </Association>
  <Association Name="FK__PersonAdd__Perso__276EDEB3">
    <End Role="Person" Type="Self.Person" Multiplicity="0..1" />
    <End Role="PersonAddress" Type="Self.PersonAddress" Multiplicity="*" />
    <ReferentialConstraint>
      <Principal Role="Person">
        <PropertyRef Name="PersonKey" />
      </Principal>
      <Dependent Role="PersonAddress">
        <PropertyRef Name="PersonKey" />
      </Dependent>
    </ReferentialConstraint>
  </Association>
  <EntityContainer Name="CommunityAssist2017Entities" annotation:LazyLoadingEnabled="true">
    <EntitySet Name="BusinessRules" EntityType="Self.BusinessRule" />
    <EntitySet Name="Donations" EntityType="Self.Donation" />
    <EntitySet Name="Employees" EntityType="Self.Employee" />
    <EntitySet Name="EmployeePositions" EntityType="Self.EmployeePosition" />
    <EntitySet Name="GrantApplications" EntityType="Self.GrantApplication" />
    <EntitySet Name="GrantApplicationReviews" EntityType="Self.GrantApplicationReview" />
    <EntitySet Name="GrantApplicationStatus" EntityType="Self.GrantApplicationStatu" />
    <EntitySet Name="GrantTypes" EntityType="Self.GrantType" />
    <EntitySet Name="LoginHistories" EntityType="Self.LoginHistory" />
    <EntitySet Name="People" EntityType="Self.Person" />
    <EntitySet Name="PersonAddresses" EntityType="Self.PersonAddress" />
    <EntitySet Name="Positions" EntityType="Self.Position" />
    <AssociationSet Name="FK__Donation__Person__3A81B327" Association="Self.FK__Donation__Person__3A81B327">
      <End Role="Person" EntitySet="People" />
      <End Role="Donation" EntitySet="Donations" />
    </AssociationSet>
    <AssociationSet Name="FK__Employee__Person__300424B4" Association="Self.FK__Employee__Person__300424B4">
      <End Role="Person" EntitySet="People" />
      <End Role="Employee" EntitySet="Employees" />
    </AssociationSet>
    <AssociationSet Name="FK__EmployeeP__Emplo__33D4B598" Association="Self.FK__EmployeeP__Emplo__33D4B598">
      <End Role="Employee" EntitySet="Employees" />
      <End Role="EmployeePosition" EntitySet="EmployeePositions" />
    </AssociationSet>
    <AssociationSet Name="FK__GrantAppl__Emplo__48CFD27E" Association="Self.FK__GrantAppl__Emplo__48CFD27E">
      <End Role="Employee" EntitySet="Employees" />
      <End Role="GrantApplicationReview" EntitySet="GrantApplicationReviews" />
    </AssociationSet>
    <AssociationSet Name="FK__EmployeeP__Posit__32E0915F" Association="Self.FK__EmployeeP__Posit__32E0915F">
      <End Role="Position" EntitySet="Positions" />
      <End Role="EmployeePosition" EntitySet="EmployeePositions" />
    </AssociationSet>
    <AssociationSet Name="FK__GrantAppl__Grant__4316F928" Association="Self.FK__GrantAppl__Grant__4316F928">
      <End Role="GrantType" EntitySet="GrantTypes" />
      <End Role="GrantApplication" EntitySet="GrantApplications" />
    </AssociationSet>
    <AssociationSet Name="FK__GrantAppl__Grant__440B1D61" Association="Self.FK__GrantAppl__Grant__440B1D61">
      <End Role="GrantApplicationStatus" EntitySet="GrantApplicationStatus" />
      <End Role="GrantApplication" EntitySet="GrantApplications" />
    </AssociationSet>
    <AssociationSet Name="FK__GrantAppl__Grant__47DBAE45" Association="Self.FK__GrantAppl__Grant__47DBAE45">
      <End Role="GrantApplication" EntitySet="GrantApplications" />
      <End Role="GrantApplicationReview" EntitySet="GrantApplicationReviews" />
    </AssociationSet>
    <AssociationSet Name="FK__GrantAppl__Perso__412EB0B6" Association="Self.FK__GrantAppl__Perso__412EB0B6">
      <End Role="Person" EntitySet="People" />
      <End Role="GrantApplication" EntitySet="GrantApplications" />
    </AssociationSet>
    <AssociationSet Name="FK__LoginHist__Perso__4CA06362" Association="Self.FK__LoginHist__Perso__4CA06362">
      <End Role="Person" EntitySet="People" />
      <End Role="LoginHistory" EntitySet="LoginHistories" />
    </AssociationSet>
    <AssociationSet Name="FK__PersonAdd__Perso__276EDEB3" Association="Self.FK__PersonAdd__Perso__276EDEB3">
      <End Role="Person" EntitySet="People" />
      <End Role="PersonAddress" EntitySet="PersonAddresses" />
    </AssociationSet>
    <FunctionImport Name="usp_Login">
      <Parameter Name="Email" Mode="In" Type="String" />
      <Parameter Name="password" Mode="In" Type="String" />
    </FunctionImport>
    <FunctionImport Name="usp_Register">
      <Parameter Name="lastname" Mode="In" Type="String" />
      <Parameter Name="firstname" Mode="In" Type="String" />
      <Parameter Name="email" Mode="In" Type="String" />
      <Parameter Name="password" Mode="In" Type="String" />
      <Parameter Name="ApartmentNumber" Mode="In" Type="String" />
      <Parameter Name="Street" Mode="In" Type="String" />
      <Parameter Name="City" Mode="In" Type="String" />
      <Parameter Name="State" Mode="In" Type="String" />
      <Parameter Name="Zipcode" Mode="In" Type="String" />
      <Parameter Name="Phone" Mode="In" Type="String" />
    </FunctionImport>
  </EntityContainer>
</Schema>
© 2018 GitHub, Inc.
