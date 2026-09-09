using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValueItem
public class RESTST_d32097d2629a99529d77b865dae9fb0cStructure : AbstractRESTStructure<ST_d32097d2629a99529d77b865dae9fb0cStructure> {
[JsonProperty("BusinessPhones")]
public RestList<string> AttrBusinessPhones;

[JsonProperty("DisplayName")]
public string AttrDisplayName;

[JsonProperty("GivenName")]
public string AttrGivenName;

[JsonProperty("JobTitle")]
public string AttrJobTitle;

[JsonProperty("Mail")]
public string AttrMail;

[JsonProperty("MobilePhone")]
public string AttrMobilePhone;

[JsonProperty("OfficeLocation")]
public string AttrOfficeLocation;

[JsonProperty("PreferredLanguage")]
public string AttrPreferredLanguage;

[JsonProperty("Surname")]
public string AttrSurname;

[JsonProperty("UserPrincipalName")]
public string AttrUserPrincipalName;

[JsonProperty("Id")]
public string AttrId;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("RoleTemplateId")]
public string AttrRoleTemplateId;

[JsonProperty("odata_context")]
public string Attrodata_context;

[JsonProperty("Department")]
public string AttrDepartment;

[JsonProperty("OnPremisesSamAccountName")]
public string AttrOnPremisesSamAccountName;

[JsonProperty("City")]
public string AttrCity;

[JsonProperty("OnPremisesExtensionAttributes")]
public ssConectaProveedores.RestRecords.RESTST_f5088e93197e1d0bc0e83e9a247c44fbStructure AttrOnPremisesExtensionAttributes;

[JsonProperty("OnPremisesDistinguishedName")]
public string AttrOnPremisesDistinguishedName;

[JsonProperty("extension_914754251c5a475cadb45125f912505d_telceld")]
public string Attrextension_914754251c5a475cadb45125f912505d_telceld;

[JsonProperty("extension_914754251c5a475cadb45125f912505d_telcels")]
public string Attrextension_914754251c5a475cadb45125f912505d_telcels;

[JsonProperty("extension_914754251c5a475cadb45125f912505d_telcelg")]
public string Attrextension_914754251c5a475cadb45125f912505d_telcelg;

[JsonProperty("extension_c6cd2ec32e9743dfb128ea5206abd537_amDirec")]
public string Attrextension_c6cd2ec32e9743dfb128ea5206abd537_amDirec;

[JsonProperty("extension_c6cd2ec32e9743dfb128ea5206abd537_amSubdi")]
public string Attrextension_c6cd2ec32e9743dfb128ea5206abd537_amSubdi;

[JsonProperty("extension_c6cd2ec32e9743dfb128ea5206abd537_amGeren")]
public string Attrextension_c6cd2ec32e9743dfb128ea5206abd537_amGeren;

public RESTST_d32097d2629a99529d77b865dae9fb0cStructure() { }

public RESTST_d32097d2629a99529d77b865dae9fb0cStructure (ST_d32097d2629a99529d77b865dae9fb0cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBusinessPhones = s.ssBusinessPhones.Length == 0 ? null : s.ssBusinessPhones.ToRestList();
AttrDisplayName = ConvertToRestWithoutDefaults(s.ssDisplayName, "");
AttrGivenName = ConvertToRestWithoutDefaults(s.ssGivenName, "");
AttrJobTitle = ConvertToRestWithoutDefaults(s.ssJobTitle, "");
AttrMail = ConvertToRestWithoutDefaults(s.ssMail, "");
AttrMobilePhone = ConvertToRestWithoutDefaults(s.ssMobilePhone, "");
AttrOfficeLocation = ConvertToRestWithoutDefaults(s.ssOfficeLocation, "");
AttrPreferredLanguage = ConvertToRestWithoutDefaults(s.ssPreferredLanguage, "");
AttrSurname = ConvertToRestWithoutDefaults(s.ssSurname, "");
AttrUserPrincipalName = ConvertToRestWithoutDefaults(s.ssUserPrincipalName, "");
AttrId = ConvertToRestWithoutDefaults(s.ssId, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrRoleTemplateId = ConvertToRestWithoutDefaults(s.ssRoleTemplateId, "");
Attrodata_context = ConvertToRestWithoutDefaults(s.ssodata_context, "");
AttrDepartment = ConvertToRestWithoutDefaults(s.ssDepartment, "");
AttrOnPremisesSamAccountName = ConvertToRestWithoutDefaults(s.ssOnPremisesSamAccountName, "");
AttrCity = ConvertToRestWithoutDefaults(s.ssCity, "");
AttrOnPremisesExtensionAttributes = ConvertToRestWithoutDefaults(s.ssOnPremisesExtensionAttributes, new ST_f5088e93197e1d0bc0e83e9a247c44fbStructure(), ssConectaProveedores.RestRecords.RESTST_f5088e93197e1d0bc0e83e9a247c44fbStructure.FromStructure, config);
AttrOnPremisesDistinguishedName = ConvertToRestWithoutDefaults(s.ssOnPremisesDistinguishedName, "");
Attrextension_914754251c5a475cadb45125f912505d_telceld = ConvertToRestWithoutDefaults(s.ssextension_914754251c5a475cadb45125f912505d_telceld, "");
Attrextension_914754251c5a475cadb45125f912505d_telcels = ConvertToRestWithoutDefaults(s.ssextension_914754251c5a475cadb45125f912505d_telcels, "");
Attrextension_914754251c5a475cadb45125f912505d_telcelg = ConvertToRestWithoutDefaults(s.ssextension_914754251c5a475cadb45125f912505d_telcelg, "");
Attrextension_c6cd2ec32e9743dfb128ea5206abd537_amDirec = ConvertToRestWithoutDefaults(s.ssextension_c6cd2ec32e9743dfb128ea5206abd537_amDirec, "");
Attrextension_c6cd2ec32e9743dfb128ea5206abd537_amSubdi = ConvertToRestWithoutDefaults(s.ssextension_c6cd2ec32e9743dfb128ea5206abd537_amSubdi, "");
Attrextension_c6cd2ec32e9743dfb128ea5206abd537_amGeren = ConvertToRestWithoutDefaults(s.ssextension_c6cd2ec32e9743dfb128ea5206abd537_amGeren, "");
  } else {
AttrBusinessPhones = s.ssBusinessPhones.ToRestList();
AttrDisplayName = s.ssDisplayName;
AttrGivenName = s.ssGivenName;
AttrJobTitle = s.ssJobTitle;
AttrMail = s.ssMail;
AttrMobilePhone = s.ssMobilePhone;
AttrOfficeLocation = s.ssOfficeLocation;
AttrPreferredLanguage = s.ssPreferredLanguage;
AttrSurname = s.ssSurname;
AttrUserPrincipalName = s.ssUserPrincipalName;
AttrId = s.ssId;
AttrDescription = s.ssDescription;
AttrRoleTemplateId = s.ssRoleTemplateId;
Attrodata_context = s.ssodata_context;
AttrDepartment = s.ssDepartment;
AttrOnPremisesSamAccountName = s.ssOnPremisesSamAccountName;
AttrCity = s.ssCity;
AttrOnPremisesExtensionAttributes = ssConectaProveedores.RestRecords.RESTST_f5088e93197e1d0bc0e83e9a247c44fbStructure.FromStructure(s.ssOnPremisesExtensionAttributes, config);
AttrOnPremisesDistinguishedName = s.ssOnPremisesDistinguishedName;
Attrextension_914754251c5a475cadb45125f912505d_telceld = s.ssextension_914754251c5a475cadb45125f912505d_telceld;
Attrextension_914754251c5a475cadb45125f912505d_telcels = s.ssextension_914754251c5a475cadb45125f912505d_telcels;
Attrextension_914754251c5a475cadb45125f912505d_telcelg = s.ssextension_914754251c5a475cadb45125f912505d_telcelg;
Attrextension_c6cd2ec32e9743dfb128ea5206abd537_amDirec = s.ssextension_c6cd2ec32e9743dfb128ea5206abd537_amDirec;
Attrextension_c6cd2ec32e9743dfb128ea5206abd537_amSubdi = s.ssextension_c6cd2ec32e9743dfb128ea5206abd537_amSubdi;
Attrextension_c6cd2ec32e9743dfb128ea5206abd537_amGeren = s.ssextension_c6cd2ec32e9743dfb128ea5206abd537_amGeren;
  }
}

public static ST_d32097d2629a99529d77b865dae9fb0cStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_d32097d2629a99529d77b865dae9fb0cStructure obj) { 
  ST_d32097d2629a99529d77b865dae9fb0cStructure s = new ST_d32097d2629a99529d77b865dae9fb0cStructure();
  if(obj != null) {
  s.ssBusinessPhones = BasicTypeList<string>.FromRestList(obj.AttrBusinessPhones);
  s.ssDisplayName = obj.AttrDisplayName == null ? "" : obj.AttrDisplayName;
  s.ssGivenName = obj.AttrGivenName == null ? "" : obj.AttrGivenName;
  s.ssJobTitle = obj.AttrJobTitle == null ? "" : obj.AttrJobTitle;
  s.ssMail = obj.AttrMail == null ? "" : obj.AttrMail;
  s.ssMobilePhone = obj.AttrMobilePhone == null ? "" : obj.AttrMobilePhone;
  s.ssOfficeLocation = obj.AttrOfficeLocation == null ? "" : obj.AttrOfficeLocation;
  s.ssPreferredLanguage = obj.AttrPreferredLanguage == null ? "" : obj.AttrPreferredLanguage;
  s.ssSurname = obj.AttrSurname == null ? "" : obj.AttrSurname;
  s.ssUserPrincipalName = obj.AttrUserPrincipalName == null ? "" : obj.AttrUserPrincipalName;
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssRoleTemplateId = obj.AttrRoleTemplateId == null ? "" : obj.AttrRoleTemplateId;
  s.ssodata_context = obj.Attrodata_context == null ? "" : obj.Attrodata_context;
  s.ssDepartment = obj.AttrDepartment == null ? "" : obj.AttrDepartment;
  s.ssOnPremisesSamAccountName = obj.AttrOnPremisesSamAccountName == null ? "" : obj.AttrOnPremisesSamAccountName;
  s.ssCity = obj.AttrCity == null ? "" : obj.AttrCity;
  s.ssOnPremisesExtensionAttributes = ssConectaProveedores.RestRecords.RESTST_f5088e93197e1d0bc0e83e9a247c44fbStructure.ToStructure(obj.AttrOnPremisesExtensionAttributes);
  s.ssOnPremisesDistinguishedName = obj.AttrOnPremisesDistinguishedName == null ? "" : obj.AttrOnPremisesDistinguishedName;
  s.ssextension_914754251c5a475cadb45125f912505d_telceld = obj.Attrextension_914754251c5a475cadb45125f912505d_telceld == null ? "" : obj.Attrextension_914754251c5a475cadb45125f912505d_telceld;
  s.ssextension_914754251c5a475cadb45125f912505d_telcels = obj.Attrextension_914754251c5a475cadb45125f912505d_telcels == null ? "" : obj.Attrextension_914754251c5a475cadb45125f912505d_telcels;
  s.ssextension_914754251c5a475cadb45125f912505d_telcelg = obj.Attrextension_914754251c5a475cadb45125f912505d_telcelg == null ? "" : obj.Attrextension_914754251c5a475cadb45125f912505d_telcelg;
  s.ssextension_c6cd2ec32e9743dfb128ea5206abd537_amDirec = obj.Attrextension_c6cd2ec32e9743dfb128ea5206abd537_amDirec == null ? "" : obj.Attrextension_c6cd2ec32e9743dfb128ea5206abd537_amDirec;
  s.ssextension_c6cd2ec32e9743dfb128ea5206abd537_amSubdi = obj.Attrextension_c6cd2ec32e9743dfb128ea5206abd537_amSubdi == null ? "" : obj.Attrextension_c6cd2ec32e9743dfb128ea5206abd537_amSubdi;
  s.ssextension_c6cd2ec32e9743dfb128ea5206abd537_amGeren = obj.Attrextension_c6cd2ec32e9743dfb128ea5206abd537_amGeren == null ? "" : obj.Attrextension_c6cd2ec32e9743dfb128ea5206abd537_amGeren;
  }
  return s;
}

public static Func<ST_d32097d2629a99529d77b865dae9fb0cStructure, ssConectaProveedores.RestRecords.RESTST_d32097d2629a99529d77b865dae9fb0cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d32097d2629a99529d77b865dae9fb0cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_d32097d2629a99529d77b865dae9fb0cStructure FromStructure(ST_d32097d2629a99529d77b865dae9fb0cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_d32097d2629a99529d77b865dae9fb0cStructure(s, config);
}

}


