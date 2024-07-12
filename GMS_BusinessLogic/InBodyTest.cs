using System;
using System.Data;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
    public class InBodyTest
    {
        private enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode = enMode.AddNew;

        public int Id {  get; set; }
        public DateTime MeasurementDate {  get; set; }
        public float Weight {  get; set; }
        public float Height {  get; set; }
        public float FatPercentage {  get; set; }
        public float MuscleMass {  get; set; }
        public float WaterPercentage {  get; set; }
        public bool FluidRetention {  get; set; }
        public int MembershipId {  get; set; }
        public Membership MembershipInfo { get; set; }


        public InBodyTest()
        {
            Id = -1;
            MeasurementDate = DateTime.Now;
            Weight = 0.0f;
            Height = 0.0f;
            FatPercentage = 0.0f;
            MuscleMass = 0.0f;
            WaterPercentage = 0.0f;
            FluidRetention = false;
            MembershipId = -1;

            _Mode = enMode.AddNew;
        }


        private InBodyTest(int id, DateTime measurementDate, float weight, float height, float fatPercentage,
            float muscleMass, float waterPercentage, bool fluidRetention, int membershipId)
        {
            Id = id;
            MeasurementDate = measurementDate;
            Weight = weight;
            Height = height;
            FatPercentage = fatPercentage;
            MuscleMass = muscleMass;
            WaterPercentage = waterPercentage;
            FluidRetention = fluidRetention;
            MembershipId = membershipId;
            MembershipInfo = Membership.find(MembershipId);

            _Mode = enMode.Update;
        }

        public static InBodyTest find(int id)
        {
            DateTime measurementDate = DateTime.Now;
            float weight = 0.0f, height = 0.0f, fatPercentage = 0.0f, muscleMass = 0.0f, waterPercentage = 0.0f;
            bool fluidRetention = false;
            int membershipId = -1;

            if (InBodyTestData.getInBodyTestInfoById(id, ref measurementDate, ref weight, ref height, ref fatPercentage,
                ref muscleMass, ref waterPercentage, ref fluidRetention, ref membershipId))
                return new InBodyTest(id, measurementDate, weight, height, fatPercentage, muscleMass, waterPercentage,
                    fluidRetention, membershipId);

            else return null;
        }

        public int add(InBodyTest obj)
        => InBodyTestData.add(obj.MeasurementDate, obj.Weight, obj.Height, obj.FatPercentage,
            obj.MuscleMass, obj.WaterPercentage, obj.FluidRetention, obj.MembershipId);

        public bool update(InBodyTest obj)
        => InBodyTestData.update(obj.Id, obj.MeasurementDate, obj.Weight, obj.Height, obj.FatPercentage,
            obj.MuscleMass, obj.WaterPercentage, obj.FluidRetention);

        public bool delete(InBodyTest obj)
        => InBodyTestData.delete(obj.Id);

        public DataTable get() => InBodyTestData.get();
    }
}
