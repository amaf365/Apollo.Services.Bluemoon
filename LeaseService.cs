using System;

namespace Apollo.Services.Bluemoon
{
    public class LeaseService
    {
        #region Properties

        public string SessionId { get; set; }  //Lease Session Id

        private svcLease.leasePortClient LeaseClient { get; set; }

        private ApartmentOrganization ApartmentOrganization { get; set; }

        #endregion

        #region Constructor

        public LeaseService(ConfigConstantsLocal credentials, ApartmentOrganization aptOrg)
        {
            this.ApartmentOrganization = aptOrg;

            this.LeaseClient = new svcLease.leasePortClient();

            this.SessionId = CreateSession(credentials);

        }

        #endregion

        #region Private Functions

        private string CreateSession(ConfigConstantsLocal credentials)
        {
            return LeaseClient.CreateSession(credentials.SerialNumber, credentials.UserId, credentials.Password);
        }

        #endregion

        #region Public Functions

        public svcLease.Form[] ListForms(ListFormsParams lformsParams)
        {
            svcLease.Form[] form = new svcLease.Form[] { };

            form = LeaseClient.ListForms(lformsParams.SessionId, lformsParams.PropertyId, lformsParams.LeaseId, lformsParams.ExcludeEsignatureRestrictedForms);

            return form;
        }

        public svcLease.Field[] ListFields(ListFieldsParams lfieldsParams)
        {
            svcLease.Field[] field = new svcLease.Field[] { };

            field = LeaseClient.ListFields(lfieldsParams.SessionId, lfieldsParams.PropertyId, lfieldsParams.StandardForms, lfieldsParams.CustomForms);

            return field;
        }

        #endregion
    }
}
