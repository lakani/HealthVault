﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace HealthVault.Entity.Model
{
    public partial class MeaslesCase
    {
        public int CaseID { get; set; }
        public DateTime? EntryDate { get; set; }
        public string Name { get; set; }
        public short? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public short? State { get; set; }
        public short? City { get; set; }
        public short? Organization { get; set; }
        public string Sub_Organization { get; set; }
        public string HomeAddress { get; set; }
        public short? Country { get; set; }
        public DateTime? Dateofonset { get; set; }
        public string EPI_ID { get; set; }
        public DateTime? Date_of_investigation { get; set; }
        public short? vaccinated { get; set; }
        public DateTime? Dateoflast_vaccination { get; set; }
        public short? VI_Status { get; set; }
        public short? Measles_Epi_linked { get; set; }
        public short? Rubella_Epi_linked { get; set; }
        public short? Number_of_days_after_travel { get; set; }
        public string Destination_of_travel { get; set; }
        public DateTime? Date_samplecollected { get; set; }
        public DateTime? Datesenttolab { get; set; }
        public short? Type_of_specimen { get; set; }
        public short? Condition_of_specimen { get; set; }
        public short? Measles_Kit { get; set; }
        public short? Rubella_Kit { get; set; }
        public short? Measles_ELISA { get; set; }
        public short? Rubella_ELISA { get; set; }
        public DateTime? Datelabreportback { get; set; }
        public short? Id_Source { get; set; }
        public short? FINAL_DIGNOSIS { get; set; }
        public string Reason_Sample_Sent2RL { get; set; }
        public string Type1stTest { get; set; }
        public short? Type2ndSpecimen { get; set; }
        public short? VG_Measles_RT_PCR { get; set; }
        public short? VG_Rubella_RT_PCR { get; set; }
        public short? measles_genotype { get; set; }
        public short? rubella_genotype { get; set; }
        public DateTime? measles_date_sent_genotyping { get; set; }
        public DateTime? rubella_date_sent_genotyping { get; set; }
        public short? Sero_Kit { get; set; }
        public short? Sample_Sent2RL { get; set; }
        public short? Sero_Measles_IgM { get; set; }
        public short? Sero_Measles_IgG { get; set; }
        public short? Sero_Rubella_IgM { get; set; }
        public short? Sero_Rubella_IgG { get; set; }
        public short? IFA_Status { get; set; }
        public short? VI_Vero_SLAM { get; set; }
        public short? IFA { get; set; }
        public short? VI_B95a { get; set; }
    }
}