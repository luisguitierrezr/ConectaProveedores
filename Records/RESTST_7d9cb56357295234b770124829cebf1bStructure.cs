using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValueItem2
public class RESTST_7d9cb56357295234b770124829cebf1bStructure : AbstractRESTStructure<ST_7d9cb56357295234b770124829cebf1bStructure> {
[JsonProperty("Id")]
public string AttrId;

[JsonProperty("CreatedDateTime")]
public String AttrCreatedDateTime;

[JsonProperty("CreationOptions")]
public RestList<string> AttrCreationOptions;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("DisplayName")]
public string AttrDisplayName;

[JsonProperty("ExpirationDateTime")]
public String AttrExpirationDateTime;

[JsonProperty("GroupTypes")]
public RestList<string> AttrGroupTypes;

[JsonProperty("Mail")]
public string AttrMail;

[JsonProperty("MailEnabled")]
public bool? AttrMailEnabled;

[JsonProperty("MailNickname")]
public string AttrMailNickname;

[JsonProperty("MembershipRule")]
public string AttrMembershipRule;

[JsonProperty("MembershipRuleProcessingState")]
public string AttrMembershipRuleProcessingState;

[JsonProperty("ProxyAddresses")]
public RestList<string> AttrProxyAddresses;

[JsonProperty("RenewedDateTime")]
public String AttrRenewedDateTime;

[JsonProperty("ResourceBehaviorOptions")]
public RestList<string> AttrResourceBehaviorOptions;

[JsonProperty("ResourceProvisioningOptions")]
public RestList<string> AttrResourceProvisioningOptions;

[JsonProperty("SecurityEnabled")]
public bool? AttrSecurityEnabled;

[JsonProperty("SecurityIdentifier")]
public string AttrSecurityIdentifier;

[JsonProperty("Visibility")]
public string AttrVisibility;

public RESTST_7d9cb56357295234b770124829cebf1bStructure() { }

public RESTST_7d9cb56357295234b770124829cebf1bStructure (ST_7d9cb56357295234b770124829cebf1bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, "");
AttrCreatedDateTime = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedDateTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreationOptions = s.ssCreationOptions.Length == 0 ? null : s.ssCreationOptions.ToRestList();
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrDisplayName = ConvertToRestWithoutDefaults(s.ssDisplayName, "");
AttrExpirationDateTime = ConvertDateTimeToRestWithoutDefaults(s.ssExpirationDateTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrGroupTypes = s.ssGroupTypes.Length == 0 ? null : s.ssGroupTypes.ToRestList();
AttrMail = ConvertToRestWithoutDefaults(s.ssMail, "");
AttrMailEnabled = ConvertToRestWithoutDefaults(s.ssMailEnabled, false);
AttrMailNickname = ConvertToRestWithoutDefaults(s.ssMailNickname, "");
AttrMembershipRule = ConvertToRestWithoutDefaults(s.ssMembershipRule, "");
AttrMembershipRuleProcessingState = ConvertToRestWithoutDefaults(s.ssMembershipRuleProcessingState, "");
AttrProxyAddresses = s.ssProxyAddresses.Length == 0 ? null : s.ssProxyAddresses.ToRestList();
AttrRenewedDateTime = ConvertDateTimeToRestWithoutDefaults(s.ssRenewedDateTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrResourceBehaviorOptions = s.ssResourceBehaviorOptions.Length == 0 ? null : s.ssResourceBehaviorOptions.ToRestList();
AttrResourceProvisioningOptions = s.ssResourceProvisioningOptions.Length == 0 ? null : s.ssResourceProvisioningOptions.ToRestList();
AttrSecurityEnabled = ConvertToRestWithoutDefaults(s.ssSecurityEnabled, false);
AttrSecurityIdentifier = ConvertToRestWithoutDefaults(s.ssSecurityIdentifier, "");
AttrVisibility = ConvertToRestWithoutDefaults(s.ssVisibility, "");
  } else {
AttrId = s.ssId;
AttrCreatedDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedDateTime, config.DateTimeFormat);
AttrCreationOptions = s.ssCreationOptions.ToRestList();
AttrDescription = s.ssDescription;
AttrDisplayName = s.ssDisplayName;
AttrExpirationDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssExpirationDateTime, config.DateTimeFormat);
AttrGroupTypes = s.ssGroupTypes.ToRestList();
AttrMail = s.ssMail;
AttrMailEnabled = (bool?) s.ssMailEnabled;
AttrMailNickname = s.ssMailNickname;
AttrMembershipRule = s.ssMembershipRule;
AttrMembershipRuleProcessingState = s.ssMembershipRuleProcessingState;
AttrProxyAddresses = s.ssProxyAddresses.ToRestList();
AttrRenewedDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssRenewedDateTime, config.DateTimeFormat);
AttrResourceBehaviorOptions = s.ssResourceBehaviorOptions.ToRestList();
AttrResourceProvisioningOptions = s.ssResourceProvisioningOptions.ToRestList();
AttrSecurityEnabled = (bool?) s.ssSecurityEnabled;
AttrSecurityIdentifier = s.ssSecurityIdentifier;
AttrVisibility = s.ssVisibility;
  }
}

public static ST_7d9cb56357295234b770124829cebf1bStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_7d9cb56357295234b770124829cebf1bStructure obj) { 
  ST_7d9cb56357295234b770124829cebf1bStructure s = new ST_7d9cb56357295234b770124829cebf1bStructure();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssCreatedDateTime = obj.AttrCreatedDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedDateTime, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreationOptions = BasicTypeList<string>.FromRestList(obj.AttrCreationOptions);
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssDisplayName = obj.AttrDisplayName == null ? "" : obj.AttrDisplayName;
  s.ssExpirationDateTime = obj.AttrExpirationDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrExpirationDateTime, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssGroupTypes = BasicTypeList<string>.FromRestList(obj.AttrGroupTypes);
  s.ssMail = obj.AttrMail == null ? "" : obj.AttrMail;
  s.ssMailEnabled = obj.AttrMailEnabled == null ? false : obj.AttrMailEnabled.Value;
  s.ssMailNickname = obj.AttrMailNickname == null ? "" : obj.AttrMailNickname;
  s.ssMembershipRule = obj.AttrMembershipRule == null ? "" : obj.AttrMembershipRule;
  s.ssMembershipRuleProcessingState = obj.AttrMembershipRuleProcessingState == null ? "" : obj.AttrMembershipRuleProcessingState;
  s.ssProxyAddresses = BasicTypeList<string>.FromRestList(obj.AttrProxyAddresses);
  s.ssRenewedDateTime = obj.AttrRenewedDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrRenewedDateTime, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssResourceBehaviorOptions = BasicTypeList<string>.FromRestList(obj.AttrResourceBehaviorOptions);
  s.ssResourceProvisioningOptions = BasicTypeList<string>.FromRestList(obj.AttrResourceProvisioningOptions);
  s.ssSecurityEnabled = obj.AttrSecurityEnabled == null ? false : obj.AttrSecurityEnabled.Value;
  s.ssSecurityIdentifier = obj.AttrSecurityIdentifier == null ? "" : obj.AttrSecurityIdentifier;
  s.ssVisibility = obj.AttrVisibility == null ? "" : obj.AttrVisibility;
  }
  return s;
}

public static Func<ST_7d9cb56357295234b770124829cebf1bStructure, ssConectaProveedores.RestRecords.RESTST_7d9cb56357295234b770124829cebf1bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7d9cb56357295234b770124829cebf1bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_7d9cb56357295234b770124829cebf1bStructure FromStructure(ST_7d9cb56357295234b770124829cebf1bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_7d9cb56357295234b770124829cebf1bStructure(s, config);
}

}


