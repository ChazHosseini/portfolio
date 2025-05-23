﻿using Microsoft.AspNetCore.Mvc;
using Zamyad.Exemption.Data.SocialDB;

namespace Zamyad.Exemption.UI.Models
{
    public class PersonnelInfoViewModel
    {
        public string PersNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmpDate { get; set; }
        public string MilMonths { get; set; }
        public string FatherName { get; set; }
        public string FolderNo { get; set; }
        public string DictumStatusCode { get; set; }
        public string DictumTypeCode { get; set; }
        public string DictumIssueDate { get; set; }
        public string DictumDoneDate { get; set; }
        public string MarriedCode { get; set; }
        public string MarriedDesc { get; set; }
        public string SexCode { get; set; }
        public string IdNo { get; set; }
        public string BirthDate { get; set; }
        public string CostCode { get; set; }
        public string CostDesc { get; set; }
        public string TotCostCode { get; set; }
        public string TotCostDesc { get; set; }
        public string EmployCode { get; set; }
        public string EmployDesc { get; set; }
        public string RankCode { get; set; }
        public string RankDesc { get; set; }
        public int? RankLevel { get; set; }
        public string PostCode { get; set; }
        public string PostDesc { get; set; }
        public string HomeAddress { get; set; }
        public string HomeStatus { get; set; }
        public int? MabnaSalary { get; set; }
        public int? SpecialMabnaSalary { get; set; }
        public int? Salary { get; set; }
        public int? HaghOlad { get; set; }
        public int? HaghMaskan { get; set; }
        public int? HaghKharobar { get; set; }
        public int? SayerMavaredPardakhti { get; set; }
        public int? FogoladehJazbMohitKar { get; set; }
        public int? MadadMaash { get; set; }
        public int? HaghBon { get; set; }
        public int? HaghTakhasosEmdadi { get; set; }
        public int? HaghTolid { get; set; }
        public int? FogoladehSharayetMohitKar { get; set; }
        public int? HaghFanni { get; set; }
        public int? TarmimHogoog { get; set; }
        public int? MozdeShoghl { get; set; }
        public int? HaghSanavat { get; set; }
        public int? HaghRotbrh { get; set; }
        public int? KhedmatBarjasteh { get; set; }
        public int? HaghPost { get; set; }
        public int? SakhtiKar { get; set; }
        public int? BazareKar { get; set; }
        public int? TafavotTatbig { get; set; }
        public int? MandegharPost { get; set; }
        public int? PayeShayestegi { get; set; }
        public int? RetbehTashvigi { get; set; }
        public int? HaghSarparasti { get; set; }
        public int? MazadTahsil { get; set; }
        public int? AfzayeshKhasModiriat { get; set; }
        public int? FogoladehHagPost { get; set; }
        public int? MazadMokammelGorooh { get; set; }
        public int? OutInsuDays { get; set; }
        public string MarryDate { get; set; }
        public string RevivalDate { get; set; }
        public string PostalCode { get; set; }
        public string StudyGradeCode { get; set; }
        public string StudyGradeDesc { get; set; }
        public byte? StudyGradeScore { get; set; }
        public string JobCode { get; set; }
        public string JobDesc { get; set; }
        public string NationalCode { get; set; }
        public string DictumGroup { get; set; }
        public string DictumGrade { get; set; }
        public string DictumCode { get; set; }
        public string BirCountryCode { get; set; }
        public string BirCityDesc { get; set; }
        public string SodCountryCode { get; set; }
        public string BirProvinceCode { get; set; }
        public string BirCityCode { get; set; }
        public string SodProvinceCode { get; set; }
        public string SodCityDesc { get; set; }
        public string SodCityCode { get; set; }
        public string CourseCode { get; set; }
        public string CourseDesc { get; set; }
        public string DictumBase { get; set; }
        public string MobileNo { get; set; }
        public string HomePhoneNo { get; set; }
        public string SahamCode { get; set; }
        public string MilitaryCode { get; set; }
        public string InsuNo { get; set; }
        public int InsuDays { get; set; }
        public string InsuranceCode { get; set; }
        public string ServiceDesc { get; set; }
        public string LastDictumCode { get; set; }
        public string Picture { get; set; }
        public int InMofidExpDays { get; set; }
        public int OutMofidExpDays { get; set; }
        public string WorkPhoneNo { get; set; }
        public string DomainCode { get; set; }
        public string DomainDesc { get; set; }
        public string ProduceorsupportDesc { get; set; }
        public decimal? BossSpecialFactor { get; set; }
        public string Produceorsupport { get; set; }
        public decimal? Expr1 { get; set; }
        public decimal? PostalRightsFactor { get; set; }
        public decimal? ProductionRightsFactor { get; set; }
        public decimal? WorkEnvCondRightsFactor { get; set; }
        public decimal? HoliOverFactor { get; set; }
        public decimal? AcordFactor { get; set; }
        public string RepPersNo { get; set; }
        public string ReligionCode { get; set; }
        public string ReligionDesc { get; set; }
        public string MazhabCode { get; set; }
        public string MazhabDesc { get; set; }
        public string DictumTypeStat { get; set; }
        public string DictumTypeDesc { get; set; }


        /// <summary>
        /// THE ABOVE Code is defining properties one by one for the top part of the page. all of them are derived from ActivePersonV
        /// </summary>
        public List<PersExemptionsView> exemptionlist { get; set; }
        public List<PersHadeseView> hadeselist { get; set; }
        public List<PersRestView> Restlist { get; set; }

        public FileContentResult PersImage { get; set; }
    }
}
