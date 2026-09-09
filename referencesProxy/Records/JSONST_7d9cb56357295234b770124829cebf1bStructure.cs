using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ValueItem2
public class JSONST_7d9cb56357295234b770124829cebf1bStructure : AbstractRESTStructure<ST_7d9cb56357295234b770124829cebf1bStructure> {
[JsonProperty("id")]
[JsonPropertyName("id")]
public string AttrId;

[JsonProperty("createdDateTime")]
[JsonPropertyName("createdDateTime")]
public String AttrCreatedDateTime;

[JsonProperty("creationOptions")]
[JsonPropertyName("creationOptions")]
public string[] AttrCreationOptions;

[JsonProperty("description")]
[JsonPropertyName("description")]
public string AttrDescription;

[JsonProperty("displayName")]
[JsonPropertyName("displayName")]
public string AttrDisplayName;

[JsonProperty("expirationDateTime")]
[JsonPropertyName("expirationDateTime")]
public String AttrExpirationDateTime;

[JsonProperty("groupTypes")]
[JsonPropertyName("groupTypes")]
public string[] AttrGroupTypes;

[JsonProperty("mail")]
[JsonPropertyName("mail")]
public string AttrMail;

[JsonProperty("mailEnabled")]
[JsonPropertyName("mailEnabled")]
public bool? AttrMailEnabled;

[JsonProperty("mailNickname")]
[JsonPropertyName("mailNickname")]
public string AttrMailNickname;

[JsonProperty("membershipRule")]
[JsonPropertyName("membershipRule")]
public string AttrMembershipRule;

[JsonProperty("membershipRuleProcessingState")]
[JsonPropertyName("membershipRuleProcessingState")]
public string AttrMembershipRuleProcessingState;

[JsonProperty("proxyAddresses")]
[JsonPropertyName("proxyAddresses")]
public string[] AttrProxyAddresses;

[JsonProperty("renewedDateTime")]
[JsonPropertyName("renewedDateTime")]
public String AttrRenewedDateTime;

[JsonProperty("resourceBehaviorOptions")]
[JsonPropertyName("resourceBehaviorOptions")]
public string[] AttrResourceBehaviorOptions;

[JsonProperty("resourceProvisioningOptions")]
[JsonPropertyName("resourceProvisioningOptions")]
public string[] AttrResourceProvisioningOptions;

[JsonProperty("securityEnabled")]
[JsonPropertyName("securityEnabled")]
public bool? AttrSecurityEnabled;

[JsonProperty("securityIdentifier")]
[JsonPropertyName("securityIdentifier")]
public string AttrSecurityIdentifier;

[JsonProperty("visibility")]
[JsonPropertyName("visibility")]
public string AttrVisibility;

public JSONST_7d9cb56357295234b770124829cebf1bStructure() { }

public JSONST_7d9cb56357295234b770124829cebf1bStructure (ST_7d9cb56357295234b770124829cebf1bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, "");
AttrCreatedDateTime = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedDateTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreationOptions = s.ssCreationOptions.Length == 0 ? null : s.ssCreationOptions.ToArray();
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrDisplayName = ConvertToRestWithoutDefaults(s.ssDisplayName, "");
AttrExpirationDateTime = ConvertDateTimeToRestWithoutDefaults(s.ssExpirationDateTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrGroupTypes = s.ssGroupTypes.Length == 0 ? null : s.ssGroupTypes.ToArray();
AttrMail = ConvertToRestWithoutDefaults(s.ssMail, "");
AttrMailEnabled = ConvertToRestWithoutDefaults(s.ssMailEnabled, false);
AttrMailNickname = ConvertToRestWithoutDefaults(s.ssMailNickname, "");
AttrMembershipRule = ConvertToRestWithoutDefaults(s.ssMembershipRule, "");
AttrMembershipRuleProcessingState = ConvertToRestWithoutDefaults(s.ssMembershipRuleProcessingState, "");
AttrProxyAddresses = s.ssProxyAddresses.Length == 0 ? null : s.ssProxyAddresses.ToArray();
AttrRenewedDateTime = ConvertDateTimeToRestWithoutDefaults(s.ssRenewedDateTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrResourceBehaviorOptions = s.ssResourceBehaviorOptions.Length == 0 ? null : s.ssResourceBehaviorOptions.ToArray();
AttrResourceProvisioningOptions = s.ssResourceProvisioningOptions.Length == 0 ? null : s.ssResourceProvisioningOptions.ToArray();
AttrSecurityEnabled = ConvertToRestWithoutDefaults(s.ssSecurityEnabled, false);
AttrSecurityIdentifier = ConvertToRestWithoutDefaults(s.ssSecurityIdentifier, "");
AttrVisibility = ConvertToRestWithoutDefaults(s.ssVisibility, "");
  } else {
AttrId = s.ssId;
AttrCreatedDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedDateTime, config.DateTimeFormat);
AttrCreationOptions = s.ssCreationOptions.ToArray();
AttrDescription = s.ssDescription;
AttrDisplayName = s.ssDisplayName;
AttrExpirationDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssExpirationDateTime, config.DateTimeFormat);
AttrGroupTypes = s.ssGroupTypes.ToArray();
AttrMail = s.ssMail;
AttrMailEnabled = (bool?) s.ssMailEnabled;
AttrMailNickname = s.ssMailNickname;
AttrMembershipRule = s.ssMembershipRule;
AttrMembershipRuleProcessingState = s.ssMembershipRuleProcessingState;
AttrProxyAddresses = s.ssProxyAddresses.ToArray();
AttrRenewedDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssRenewedDateTime, config.DateTimeFormat);
AttrResourceBehaviorOptions = s.ssResourceBehaviorOptions.ToArray();
AttrResourceProvisioningOptions = s.ssResourceProvisioningOptions.ToArray();
AttrSecurityEnabled = (bool?) s.ssSecurityEnabled;
AttrSecurityIdentifier = s.ssSecurityIdentifier;
AttrVisibility = s.ssVisibility;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure, ST_7d9cb56357295234b770124829cebf1bStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure s) => ToStructure(s, config);
}
public static ST_7d9cb56357295234b770124829cebf1bStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure obj, IBehaviorsConfiguration config) { 
  ST_7d9cb56357295234b770124829cebf1bStructure s = new ST_7d9cb56357295234b770124829cebf1bStructure();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssCreatedDateTime = obj.AttrCreatedDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedDateTime, config.DateTimeFormat);
  s.ssCreationOptions = BasicTypeList<string>.ToList(obj.AttrCreationOptions);
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssDisplayName = obj.AttrDisplayName == null ? "" : obj.AttrDisplayName;
  s.ssExpirationDateTime = obj.AttrExpirationDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrExpirationDateTime, config.DateTimeFormat);
  s.ssGroupTypes = BasicTypeList<string>.ToList(obj.AttrGroupTypes);
  s.ssMail = obj.AttrMail == null ? "" : obj.AttrMail;
  s.ssMailEnabled = obj.AttrMailEnabled == null ? false : obj.AttrMailEnabled.Value;
  s.ssMailNickname = obj.AttrMailNickname == null ? "" : obj.AttrMailNickname;
  s.ssMembershipRule = obj.AttrMembershipRule == null ? "" : obj.AttrMembershipRule;
  s.ssMembershipRuleProcessingState = obj.AttrMembershipRuleProcessingState == null ? "" : obj.AttrMembershipRuleProcessingState;
  s.ssProxyAddresses = BasicTypeList<string>.ToList(obj.AttrProxyAddresses);
  s.ssRenewedDateTime = obj.AttrRenewedDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrRenewedDateTime, config.DateTimeFormat);
  s.ssResourceBehaviorOptions = BasicTypeList<string>.ToList(obj.AttrResourceBehaviorOptions);
  s.ssResourceProvisioningOptions = BasicTypeList<string>.ToList(obj.AttrResourceProvisioningOptions);
  s.ssSecurityEnabled = obj.AttrSecurityEnabled == null ? false : obj.AttrSecurityEnabled.Value;
  s.ssSecurityIdentifier = obj.AttrSecurityIdentifier == null ? "" : obj.AttrSecurityIdentifier;
  s.ssVisibility = obj.AttrVisibility == null ? "" : obj.AttrVisibility;
  }
  return s;
}

public static Func<ST_7d9cb56357295234b770124829cebf1bStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7d9cb56357295234b770124829cebf1bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure FromStructure(ST_7d9cb56357295234b770124829cebf1bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure(s, config);
}

}


