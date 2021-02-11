using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CBT.Dtos;
using System.Web.Mvc;

namespace CBT.Controllers
{
    public class CandidateController : Controller
    {
        private CBTEntities db;

        public CandidateController()
        {
            db = new CBTEntities();
        }

        protected override void Dispose(bool disposing)
        {
            //base.Dispose(disposing);
            db.Dispose();
        }
        // GET: Candidate
        public ActionResult Candidate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveCandidate(Candidatez CandidateInfo)
        {
                      

                var candidateInDb = new Candidate();
                candidateInDb.Name = CandidateInfo.Name;
                candidateInDb.Email = CandidateInfo.Email;
                candidateInDb.Mobile = CandidateInfo.Mobile;
            
            try
            {
                db.Candidates.Add(candidateInDb);
                db.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

            return View("Candidate");
        }

        //[HttpPost]
        //public ActionResult SaveProperty(UploadDocumentViewModel PropertyDocument)
        //{

        //    try
        //    {
        //        if (PropertyDocument.PropertyInformation.id == 0)
        //        {
        //            db.rc_property_info.Add(PropertyDocument.PropertyInformation);
        //            db.SaveChanges();
        //        }
        //        else
        //        {
        //            var propertyregister = new rc_property_info();
        //            propertyregister.buildingname = PropertyDocument.PropertyInformation.buildingname;
        //            propertyregister.estate_name = PropertyDocument.PropertyInformation.estate_name;
        //            propertyregister.alias = PropertyDocument.PropertyInformation.alias;
        //            propertyregister.address = PropertyDocument.PropertyInformation.address;
        //            propertyregister.country = PropertyDocument.PropertyInformation.country;
        //            propertyregister.state = PropertyDocument.PropertyInformation.state;
        //            propertyregister.latitude = PropertyDocument.PropertyInformation.latitude;
        //            propertyregister.lga = PropertyDocument.PropertyInformation.lga;
        //            propertyregister.postcode = PropertyDocument.PropertyInformation.postcode;
        //            propertyregister.city_town = PropertyDocument.PropertyInformation.city_town;
        //            propertyregister.description = PropertyDocument.PropertyInformation.description;
        //            propertyregister.latitude = PropertyDocument.PropertyInformation.latitude;
        //            propertyregister.longitude = PropertyDocument.PropertyInformation.longitude;
        //            db.rc_property_info.Add(propertyregister);
        //            db.SaveChanges();
        //        }

        //        if (PropertyDocument.PropertyFeatures.id == 0)
        //        {
        //            db.rc_prop_features.Add(PropertyDocument.PropertyFeatures);
        //            db.SaveChanges();

        //            var numberofidenticalunits = PropertyDocument.numberofidenunit.Count();

        //            //for (int i = 0; i < numberofidenticalunits; i++)
        //            //{
        //            //    var unitnames = new rc_prop_unitname();
        //            //    unitnames.balconies = PropertyDocument.Balconies[i];
        //            //    unitnames.livingrooms = PropertyDocument.livingrooms;
        //            //    unitnames.bathrooms = PropertyDocument.bathRooms;
        //            //    unitnames.bedrooms = PropertyDocument.bedrooms;
        //            //    unitnames.halfbathrooms = PropertyDocument.halfbathroom;
        //            //    unitnames.parkinglots = PropertyDocument.parkinglots;
        //            //    unitnames.unitdescription = PropertyDocument.unitdescription;
        //            //    unitnames.unitfeatures = PropertyDocument.unitFeatures;
        //            //    unitnames.unitname = PropertyDocument.unitname;
        //            //    db.rc_prop_unitname.Add(unitnames);
        //            //    db.SaveChanges();
        //            //}

        //            //foreach (var numberofidenticalz in numberofidenticalunits)
        //            //{
        //            //    var unitnames = new rc_prop_unitname();
        //            //    unitnames.balconies = PropertyDocument.Balconies;
        //            //    unitnames.livingrooms = PropertyDocument.livingrooms;
        //            //    unitnames.bathrooms = PropertyDocument.bathRooms;
        //            //    unitnames.bedrooms = PropertyDocument.bedrooms;
        //            //    unitnames.halfbathrooms = PropertyDocument.halfbathroom;
        //            //    unitnames.parkinglots = PropertyDocument.parkinglots;
        //            //    unitnames.unitdescription = PropertyDocument.unitdescription;
        //            //    unitnames.unitfeatures = PropertyDocument.unitFeatures;
        //            //    unitnames.unitname = PropertyDocument.unitname;
        //            //    db.rc_prop_unitname.Add(unitnames);
        //            //    db.SaveChanges();
        //            //}


        //            //else 
        //            //{ 
        //            ////var unitnames = new rc_prop_unitname();
        //            ////unitnames.balconies = PropertyDocument.Balconies;
        //            ////unitnames.livingrooms = PropertyDocument.livingrooms;
        //            ////unitnames.bathrooms = PropertyDocument.bathRooms;
        //            ////unitnames.bedrooms = PropertyDocument.bedrooms;
        //            ////unitnames.halfbathrooms = PropertyDocument.halfbathroom;
        //            ////unitnames.parkinglots = PropertyDocument.parkinglots;
        //            ////unitnames.unitdescription = PropertyDocument.unitdescription;
        //            ////unitnames.unitfeatures = PropertyDocument.unitFeatures;
        //            ////unitnames.unitname = PropertyDocument.unitname;
        //            ////db.rc_prop_unitname.Add(unitnames);
        //            ////db.SaveChanges();

        //            //}
        //        }
        //        else
        //        {
        //            var propertyfeature = new rc_prop_features();
        //            propertyfeature.name = PropertyDocument.propertyType;
        //            propertyfeature.unit_features = PropertyDocument.PropertyFeatures.unit_features;
        //            propertyfeature.usage_sub_type = PropertyDocument.PropertyFeatures.usage_sub_type;
        //            propertyfeature.usage_type = PropertyDocument.PropertyFeatures.usage_type;
        //            propertyfeature.unitname = PropertyDocument.PropertyFeatures.unitname;
        //            propertyfeature.unitdescription = PropertyDocument.PropertyFeatures.unitdescription;
        //            propertyfeature.parkinglots = PropertyDocument.PropertyFeatures.parkinglots;
        //            propertyfeature.livingrooms = PropertyDocument.PropertyFeatures.livingrooms;
        //            propertyfeature.identical_unit = PropertyDocument.PropertyFeatures.identical_unit;
        //            propertyfeature.halfbathrooms = PropertyDocument.PropertyFeatures.halfbathrooms;
        //            propertyfeature.description = PropertyDocument.PropertyFeatures.description;
        //            propertyfeature.bedrooms = PropertyDocument.PropertyFeatures.bedrooms;
        //            propertyfeature.bathrooms = PropertyDocument.PropertyFeatures.bathrooms;
        //            propertyfeature.balconies = PropertyDocument.PropertyFeatures.balconies;
        //            db.rc_prop_features.Add(propertyfeature);
        //            db.SaveChanges();

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.StackTrace);
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine(ex.InnerException);
        //        Console.WriteLine(ex.Data);
        //    }




        //    if (PropertyDocument.DocumentUploadz.AgentFirstname == null && PropertyDocument.DocumentUploadz.AgentLastname == null)
        //    {
        //        PropertyDocument.DocumentUploadz.AgentEmail = PropertyDocument.ExistingAgentEmail;
        //        PropertyDocument.DocumentUploadz.AgentFirstname = PropertyDocument.ExistingAgentFirstname;
        //        PropertyDocument.DocumentUploadz.AgentLastname = PropertyDocument.ExistingAgentLastname;
        //    }
        //    else
        //    {
        //        var AgentuserRoles = new rc_prop_user_role();
        //        AgentuserRoles.email = PropertyDocument.DocumentUploadz.AgentEmail;
        //        AgentuserRoles.firstname = PropertyDocument.DocumentUploadz.AgentFirstname;
        //        AgentuserRoles.lastname = PropertyDocument.DocumentUploadz.AgentLastname;
        //        AgentuserRoles.userRole = "Agent";
        //        db.rc_prop_user_role.Add(AgentuserRoles);
        //        db.SaveChanges();

        //    }

        //    if (PropertyDocument.DocumentUploadz.EstateManagerFirstname == null && PropertyDocument.DocumentUploadz.EstateManagerLastname == null)
        //    {
        //        PropertyDocument.DocumentUploadz.EstateManagerEmail = PropertyDocument.ExistingManagerEmail;
        //        PropertyDocument.DocumentUploadz.EstateManagerFirstname = PropertyDocument.ExistingManagerFirstname;
        //        PropertyDocument.DocumentUploadz.EstateManagerLastname = PropertyDocument.ExistingManagerLastname;
        //    }
        //    else
        //    {
        //        var ManageruserRoles = new rc_prop_user_role();
        //        ManageruserRoles.email = PropertyDocument.DocumentUploadz.EstateManagerEmail;
        //        ManageruserRoles.firstname = PropertyDocument.DocumentUploadz.EstateManagerFirstname;
        //        ManageruserRoles.lastname = PropertyDocument.DocumentUploadz.EstateManagerLastname;
        //        ManageruserRoles.userRole = "Manager";
        //        db.rc_prop_user_role.Add(ManageruserRoles);
        //        db.SaveChanges();

        //    }
        //    if (PropertyDocument.DocumentUploadz.LawyerFirstname == null && PropertyDocument.DocumentUploadz.LawyerLastname == null)
        //    {
        //        PropertyDocument.DocumentUploadz.LawyerEmail = PropertyDocument.ExistingLawyerEmail;
        //        PropertyDocument.DocumentUploadz.LawyerFirstname = PropertyDocument.ExistingLawyerFirstname;
        //        PropertyDocument.DocumentUploadz.LawyerLastname = PropertyDocument.ExistingLawyerLastname;
        //    }
        //    else
        //    {
        //        var LawyeruserRoles = new rc_prop_user_role();
        //        LawyeruserRoles.email = PropertyDocument.DocumentUploadz.LawyerEmail;
        //        LawyeruserRoles.firstname = PropertyDocument.DocumentUploadz.LawyerFirstname;
        //        LawyeruserRoles.lastname = PropertyDocument.DocumentUploadz.LawyerLastname;
        //        LawyeruserRoles.userRole = "Lawyer";
        //        db.rc_prop_user_role.Add(LawyeruserRoles);
        //        db.SaveChanges();
        //    }
        //    foreach (var file in PropertyDocument.FileCofO)
        //    {
        //        if (file != null)
        //        {
        //            string filenamez = Path.GetFileNameWithoutExtension(file.FileName);
        //            string extensionz = Path.GetExtension(file.FileName);
        //            filenamez = filenamez + DateTime.Now.ToString("yymmffff") + PropertyDocument.DocumentUploadz.GenerateID + extensionz;
        //            PropertyDocument.DocumentUploadz.Cert__Of_Occupancy_Path += "~/COfOFiles/" + filenamez;
        //            filenamez = Path.Combine(Server.MapPath("~/COfOFiles/"), filenamez);
        //            file.SaveAs(filenamez);
        //        }

        //    }
        //    foreach (var file in PropertyDocument.ManageFileCofO)
        //    {
        //        if (file != null)
        //        {
        //            string filenamez = Path.GetFileNameWithoutExtension(file.FileName);
        //            string extensionz = Path.GetExtension(file.FileName);
        //            filenamez = filenamez + DateTime.Now.ToString("yymmffff") + PropertyDocument.DocumentUploadz.GenerateID + extensionz;
        //            PropertyDocument.DocumentUploadz.Cert__Of_Occupancy_Path += "~/ManagerCOfOFiles/" + filenamez;
        //            filenamez = Path.Combine(Server.MapPath("~/ManagerCOfOFiles/"), filenamez);
        //            file.SaveAs(filenamez);
        //        }

        //    }
        //    foreach (var file in PropertyDocument.filedoa)
        //    {
        //        if (file != null)
        //        {
        //            string filenamez = Path.GetFileNameWithoutExtension(file.FileName);
        //            string extensionz = Path.GetExtension(file.FileName);
        //            filenamez = filenamez + DateTime.Now.ToString("yymmffff") + PropertyDocument.DocumentUploadz.GenerateID + extensionz;
        //            PropertyDocument.DocumentUploadz.Deed_Of_Assignment_Path += "~/COfDOAFiles/" + filenamez;
        //            filenamez = Path.Combine(Server.MapPath("~/COfDOAFiles/"), filenamez);
        //            file.SaveAs(filenamez);
        //        }

        //    }
        //    foreach (var file in PropertyDocument.MFiledoa)
        //    {
        //        if (file != null)
        //        {
        //            string filenamez = Path.GetFileNameWithoutExtension(file.FileName);
        //            string extensionz = Path.GetExtension(file.FileName);
        //            filenamez = filenamez + DateTime.Now.ToString("yymmffff") + PropertyDocument.DocumentUploadz.GenerateID + extensionz;
        //            PropertyDocument.DocumentUploadz.Deed_Of_Assignment_Path += "~/ManagerCOfDOAFiles/" + filenamez;
        //            filenamez = Path.Combine(Server.MapPath("~/ManagerCOfDOAFiles/"), filenamez);
        //            file.SaveAs(filenamez);
        //        }

        //    }
        //    foreach (var file in PropertyDocument.fileo)
        //    {
        //        if (file != null)
        //        {
        //            string filenamez = Path.GetFileNameWithoutExtension(file.FileName);
        //            string extensionz = Path.GetExtension(file.FileName);
        //            filenamez = filenamez + DateTime.Now.ToString("yymmffff") + PropertyDocument.DocumentUploadz.GenerateID + extensionz;
        //            PropertyDocument.DocumentUploadz.Others_Path += "~/OtherFiles/" + filenamez;
        //            filenamez = Path.Combine(Server.MapPath("~/OtherFiles/"), filenamez);
        //            file.SaveAs(filenamez);
        //        }

        //    }
        //    foreach (var file in PropertyDocument.MFileo)
        //    {
        //        if (file != null)
        //        {
        //            string filenamez = Path.GetFileNameWithoutExtension(file.FileName);
        //            string extensionz = Path.GetExtension(file.FileName);
        //            filenamez = filenamez + DateTime.Now.ToString("yymmffff") + PropertyDocument.DocumentUploadz.GenerateID + extensionz;
        //            PropertyDocument.DocumentUploadz.Others_Path += "~/ManagerOtherFiles/" + filenamez;
        //            filenamez = Path.Combine(Server.MapPath("~/ManagerOtherFiles/"), filenamez);
        //            file.SaveAs(filenamez);
        //        }

        //    }
        //    PropertyDocument.DocumentUploadz.status = 0;
        //    PropertyDocument.DocumentUploadz.active = 1;
        //    db.Configuration.LazyLoadingEnabled = false;
        //    db.Configuration.ProxyCreationEnabled = false;
        //    if (PropertyDocument.DocumentUploadz.id == 0) db.rc_prop_document_upload.Add(PropertyDocument.DocumentUploadz);
        //    else
        //    {
        //        var propertyDocumentInDb = db.rc_prop_document_upload.SingleOrDefault(u => u.id == PropertyDocument.DocumentUploadz.id);
        //        propertyDocumentInDb.GenerateID = PropertyDocument.DocumentUploadz.GenerateID;
        //        propertyDocumentInDb.Cert__Of_Occupancy_Path = PropertyDocument.DocumentUploadz.Cert__Of_Occupancy_Path;
        //        propertyDocumentInDb.Deed_Of_Assignment_Path = PropertyDocument.DocumentUploadz.Deed_Of_Assignment_Path;
        //        propertyDocumentInDb.Others_Path = PropertyDocument.DocumentUploadz.Others_Path;
        //        propertyDocumentInDb.LandSize = PropertyDocument.DocumentUploadz.LandSize;
        //        propertyDocumentInDb.BuildingSize = PropertyDocument.DocumentUploadz.BuildingSize;
        //        propertyDocumentInDb.SpaceSize = PropertyDocument.DocumentUploadz.SpaceSize;
        //        propertyDocumentInDb.YearPropertyBuilt = PropertyDocument.DocumentUploadz.YearPropertyBuilt;
        //        propertyDocumentInDb.YearPropertyAcquired = PropertyDocument.DocumentUploadz.YearPropertyAcquired;
        //        propertyDocumentInDb.EstateManagerEmail = PropertyDocument.DocumentUploadz.EstateManagerEmail;
        //        propertyDocumentInDb.EstateManagerFirstname = PropertyDocument.DocumentUploadz.EstateManagerFirstname;
        //        propertyDocumentInDb.EstateManagerLastname = PropertyDocument.DocumentUploadz.EstateManagerLastname;
        //        propertyDocumentInDb.AgentEmail = PropertyDocument.DocumentUploadz.AgentEmail;
        //        propertyDocumentInDb.AgentFirstname = PropertyDocument.DocumentUploadz.AgentFirstname;
        //        propertyDocumentInDb.AgentLastname = PropertyDocument.DocumentUploadz.AgentLastname;
        //        propertyDocumentInDb.LawyerEmail = PropertyDocument.DocumentUploadz.LawyerEmail;
        //        propertyDocumentInDb.LawyerFirstname = PropertyDocument.DocumentUploadz.LawyerFirstname;
        //        propertyDocumentInDb.LawyerLastname = PropertyDocument.DocumentUploadz.LawyerLastname;
        //        propertyDocumentInDb.active = 1;
        //        propertyDocumentInDb.status = 1;
        //    }
        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.StackTrace);
        //        Console.WriteLine(ex.InnerException);
        //        Console.WriteLine(ex.Message);
        //    }



        //    return View("CreateWizard");
        //}
    }
}