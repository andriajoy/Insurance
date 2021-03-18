using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InsuranceDBfirst.Models;

namespace InsuranceDBfirst.Controllers
{
    public class PolicyController : Controller
    {
        // GET: Policy
        public ActionResult AddPolicy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPolicy(Policy policy)
        {
            InsuranceDBContext db = new InsuranceDBContext();
            db.USP_AddPolicies(policy.PlanNumber, policy.InstallmentPremium, policy.Insured, policy.SumAssured, policy.PolicyStatus, policy.PremiumMode, policy.PremiumDueDate, policy.Beneficiary, policy.Owner, policy.PolicyTerm);
            db.SaveChanges();

            return View();
        }
        public ActionResult UpdatePolicy(Policy policy)
        {
            InsuranceDBContext db = new InsuranceDBContext();
            db.USP_UpdatePolicies(policy.PlanNumber, policy.InstallmentPremium, policy.Insured, policy.SumAssured, policy.PolicyStatus, policy.PremiumMode, policy.PremiumDueDate, policy.Beneficiary, policy.Owner, policy.PolicyTerm);
            db.SaveChanges();

            return View();
        }
        public ActionResult DeletePolicy(int policyno)
        {
            InsuranceDBContext db = new InsuranceDBContext();
            db.USP_DeletePolicies(policyno);
            db.SaveChanges();

            return View();
        }
        public ActionResult ShowPolicies()
        {
            InsuranceDBContext db = new InsuranceDBContext();
            db.USP_ShowPolicies();
            return View();
        }
    }
}