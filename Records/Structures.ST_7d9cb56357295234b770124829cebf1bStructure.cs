namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ValueItem2 (gj1b3YSis06phTKOUwj3mQ)
///  <code>ST_7d9cb56357295234b770124829cebf1bStructure</code> that represents <code>ValueItem2</code
/// > <p>Description: </p>
/// </summary>
// Name: ValueItem2
public partial struct ST_7d9cb56357295234b770124829cebf1bStructure : ITypedRecord<ST_7d9cb56357295234b770124829cebf1bStructure> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*l4bYdXe5BUWfHRyO2JVCiw");
internal static readonly GlobalObjectKey IdCreatedDateTime = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*Y50FvPBg60uHRUKCIK8lUw");
internal static readonly GlobalObjectKey IdCreationOptions = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*3LXzT4et+U6uTCgIgkD5DQ");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*bAEE7b8Ylkik+HOHEyS3dQ");
internal static readonly GlobalObjectKey IdDisplayName = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*03Jfvdnd1U6EET2xfSwlSQ");
internal static readonly GlobalObjectKey IdExpirationDateTime = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*ASUDoG0R0kWGEKiJobRj0w");
internal static readonly GlobalObjectKey IdGroupTypes = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*EKVafayKhEqCJFsW5AAKnQ");
internal static readonly GlobalObjectKey IdMail = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*cGC8S9z9dUaVKRzbfpg6MQ");
internal static readonly GlobalObjectKey IdMailEnabled = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*LSEp5jIjQk2CerZvIKppqg");
internal static readonly GlobalObjectKey IdMailNickname = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*2DT95I_z7ESlrIbRmCa61Q");
internal static readonly GlobalObjectKey IdMembershipRule = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*QceQD0KOrUe1EGzW6hTIsw");
internal static readonly GlobalObjectKey IdMembershipRuleProcessingState = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*__Y5M+j+uECjPaWZ7DOadA");
internal static readonly GlobalObjectKey IdProxyAddresses = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*06B7DL9hykSI37qdnkK0sg");
internal static readonly GlobalObjectKey IdRenewedDateTime = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*vibZNBLrZkWZUxkFhl+HcQ");
internal static readonly GlobalObjectKey IdResourceBehaviorOptions = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*i0ZP6ZcDO0W2XZkE0d4zkA");
internal static readonly GlobalObjectKey IdResourceProvisioningOptions = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*trg4CzoHM0K0J_bITlaLug");
internal static readonly GlobalObjectKey IdSecurityEnabled = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*OVY0gBX4tUOBqiWsxyjusw");
internal static readonly GlobalObjectKey IdSecurityIdentifier = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*2TBVgJHAjUmWFsbnyNbyAA");
internal static readonly GlobalObjectKey IdVisibility = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*FD08E6+pjkq_4GT2QRVXxQ");

public string ssId;

public DateTime ssCreatedDateTime;

public BasicTypeList<string> ssCreationOptions;

public string ssDescription;

public string ssDisplayName;

public DateTime ssExpirationDateTime;

public BasicTypeList<string> ssGroupTypes;

public string ssMail;

public bool ssMailEnabled;

public string ssMailNickname;

public string ssMembershipRule;

public string ssMembershipRuleProcessingState;

public BasicTypeList<string> ssProxyAddresses;

public DateTime ssRenewedDateTime;

public BasicTypeList<string> ssResourceBehaviorOptions;

public BasicTypeList<string> ssResourceProvisioningOptions;

public bool ssSecurityEnabled;

public string ssSecurityIdentifier;

public string ssVisibility;


public BitArray OptimizedAttributes;

public ST_7d9cb56357295234b770124829cebf1bStructure() {
OptimizedAttributes = null;
ssId = "";
ssCreatedDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssCreationOptions = new BasicTypeList<string>();
ssDescription = "";
ssDisplayName = "";
ssExpirationDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssGroupTypes = new BasicTypeList<string>();
ssMail = "";
ssMailEnabled = false;
ssMailNickname = "";
ssMembershipRule = "";
ssMembershipRuleProcessingState = "";
ssProxyAddresses = new BasicTypeList<string>();
ssRenewedDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssResourceBehaviorOptions = new BasicTypeList<string>();
ssResourceProvisioningOptions = new BasicTypeList<string>();
ssSecurityEnabled = false;
ssSecurityIdentifier = "";
ssVisibility = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssId = r.ReadText(index++, "ValueItem2.Id", "");
ssCreatedDateTime = r.ReadDateTime(index++, "ValueItem2.CreatedDateTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssDescription = r.ReadText(index++, "ValueItem2.Description", "");
ssDisplayName = r.ReadText(index++, "ValueItem2.DisplayName", "");
ssExpirationDateTime = r.ReadDateTime(index++, "ValueItem2.ExpirationDateTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMail = r.ReadText(index++, "ValueItem2.Mail", "");
ssMailEnabled = r.ReadBoolean(index++, "ValueItem2.MailEnabled", false);
ssMailNickname = r.ReadText(index++, "ValueItem2.MailNickname", "");
ssMembershipRule = r.ReadText(index++, "ValueItem2.MembershipRule", "");
ssMembershipRuleProcessingState = r.ReadText(index++, "ValueItem2.MembershipRuleProcessingState", "");
ssRenewedDateTime = r.ReadDateTime(index++, "ValueItem2.RenewedDateTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssSecurityEnabled = r.ReadBoolean(index++, "ValueItem2.SecurityEnabled", false);
ssSecurityIdentifier = r.ReadText(index++, "ValueItem2.SecurityIdentifier", "");
ssVisibility = r.ReadText(index++, "ValueItem2.Visibility", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_7d9cb56357295234b770124829cebf1bStructure r) {
this = r;
}


public static bool operator == (ST_7d9cb56357295234b770124829cebf1bStructure a, ST_7d9cb56357295234b770124829cebf1bStructure b) {
if (a.ssId != b.ssId) return false;
if (a.ssCreatedDateTime != b.ssCreatedDateTime) return false;
if (a.ssCreationOptions != b.ssCreationOptions) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssDisplayName != b.ssDisplayName) return false;
if (a.ssExpirationDateTime != b.ssExpirationDateTime) return false;
if (a.ssGroupTypes != b.ssGroupTypes) return false;
if (a.ssMail != b.ssMail) return false;
if (a.ssMailEnabled != b.ssMailEnabled) return false;
if (a.ssMailNickname != b.ssMailNickname) return false;
if (a.ssMembershipRule != b.ssMembershipRule) return false;
if (a.ssMembershipRuleProcessingState != b.ssMembershipRuleProcessingState) return false;
if (a.ssProxyAddresses != b.ssProxyAddresses) return false;
if (a.ssRenewedDateTime != b.ssRenewedDateTime) return false;
if (a.ssResourceBehaviorOptions != b.ssResourceBehaviorOptions) return false;
if (a.ssResourceProvisioningOptions != b.ssResourceProvisioningOptions) return false;
if (a.ssSecurityEnabled != b.ssSecurityEnabled) return false;
if (a.ssSecurityIdentifier != b.ssSecurityIdentifier) return false;
if (a.ssVisibility != b.ssVisibility) return false;
return true;
}

public static bool operator != (ST_7d9cb56357295234b770124829cebf1bStructure a, ST_7d9cb56357295234b770124829cebf1bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7d9cb56357295234b770124829cebf1bStructure)) return false;
return (this == (ST_7d9cb56357295234b770124829cebf1bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssCreatedDateTime.GetHashCode()
 ^ ssCreationOptions.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssDisplayName.GetHashCode()
 ^ ssExpirationDateTime.GetHashCode()
 ^ ssGroupTypes.GetHashCode()
 ^ ssMail.GetHashCode()
 ^ ssMailEnabled.GetHashCode()
 ^ ssMailNickname.GetHashCode()
 ^ ssMembershipRule.GetHashCode()
 ^ ssMembershipRuleProcessingState.GetHashCode()
 ^ ssProxyAddresses.GetHashCode()
 ^ ssRenewedDateTime.GetHashCode()
 ^ ssResourceBehaviorOptions.GetHashCode()
 ^ ssResourceProvisioningOptions.GetHashCode()
 ^ ssSecurityEnabled.GetHashCode()
 ^ ssSecurityIdentifier.GetHashCode()
 ^ ssVisibility.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssCreationOptions.RecursiveReset();
ssGroupTypes.RecursiveReset();
ssProxyAddresses.RecursiveReset();
ssResourceBehaviorOptions.RecursiveReset();
ssResourceProvisioningOptions.RecursiveReset();
}

public void InternalRecursiveSave() {
ssCreationOptions.InternalRecursiveSave();
ssGroupTypes.InternalRecursiveSave();
ssProxyAddresses.InternalRecursiveSave();
ssResourceBehaviorOptions.InternalRecursiveSave();
ssResourceProvisioningOptions.InternalRecursiveSave();
}


public ST_7d9cb56357295234b770124829cebf1bStructure Duplicate() {
ST_7d9cb56357295234b770124829cebf1bStructure t;
t.ssId = this.ssId;
t.ssCreatedDateTime = this.ssCreatedDateTime;
t.ssCreationOptions = (BasicTypeList<string>)this.ssCreationOptions.Duplicate();
t.ssDescription = this.ssDescription;
t.ssDisplayName = this.ssDisplayName;
t.ssExpirationDateTime = this.ssExpirationDateTime;
t.ssGroupTypes = (BasicTypeList<string>)this.ssGroupTypes.Duplicate();
t.ssMail = this.ssMail;
t.ssMailEnabled = this.ssMailEnabled;
t.ssMailNickname = this.ssMailNickname;
t.ssMembershipRule = this.ssMembershipRule;
t.ssMembershipRuleProcessingState = this.ssMembershipRuleProcessingState;
t.ssProxyAddresses = (BasicTypeList<string>)this.ssProxyAddresses.Duplicate();
t.ssRenewedDateTime = this.ssRenewedDateTime;
t.ssResourceBehaviorOptions = (BasicTypeList<string>)this.ssResourceBehaviorOptions.Duplicate();
t.ssResourceProvisioningOptions = (BasicTypeList<string>)this.ssResourceProvisioningOptions.Duplicate();
t.ssSecurityEnabled = this.ssSecurityEnabled;
t.ssSecurityIdentifier = this.ssSecurityIdentifier;
t.ssVisibility = this.ssVisibility;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "createddatetime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedDateTime")) variable.Value = ssCreatedDateTime; else variable.Optimized = true;
} else if (head == "creationoptions") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreationOptions")) variable.Value = ssCreationOptions; else variable.Optimized = true;
variable.SetFieldName("creationoptions");
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "displayname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DisplayName")) variable.Value = ssDisplayName; else variable.Optimized = true;
} else if (head == "expirationdatetime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExpirationDateTime")) variable.Value = ssExpirationDateTime; else variable.Optimized = true;
} else if (head == "grouptypes") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GroupTypes")) variable.Value = ssGroupTypes; else variable.Optimized = true;
variable.SetFieldName("grouptypes");
} else if (head == "mail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Mail")) variable.Value = ssMail; else variable.Optimized = true;
} else if (head == "mailenabled") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MailEnabled")) variable.Value = ssMailEnabled; else variable.Optimized = true;
} else if (head == "mailnickname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MailNickname")) variable.Value = ssMailNickname; else variable.Optimized = true;
} else if (head == "membershiprule") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MembershipRule")) variable.Value = ssMembershipRule; else variable.Optimized = true;
} else if (head == "membershipruleprocessingstate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MembershipRuleProcessingState")) variable.Value = ssMembershipRuleProcessingState; else variable.Optimized = true;
} else if (head == "proxyaddresses") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProxyAddresses")) variable.Value = ssProxyAddresses; else variable.Optimized = true;
variable.SetFieldName("proxyaddresses");
} else if (head == "reneweddatetime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RenewedDateTime")) variable.Value = ssRenewedDateTime; else variable.Optimized = true;
} else if (head == "resourcebehavioroptions") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ResourceBehaviorOptions")) variable.Value = ssResourceBehaviorOptions; else variable.Optimized = true;
variable.SetFieldName("resourcebehavioroptions");
} else if (head == "resourceprovisioningoptions") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ResourceProvisioningOptions")) variable.Value = ssResourceProvisioningOptions; else variable.Optimized = true;
variable.SetFieldName("resourceprovisioningoptions");
} else if (head == "securityenabled") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SecurityEnabled")) variable.Value = ssSecurityEnabled; else variable.Optimized = true;
} else if (head == "securityidentifier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SecurityIdentifier")) variable.Value = ssSecurityIdentifier; else variable.Optimized = true;
} else if (head == "visibility") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Visibility")) variable.Value = ssVisibility; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdCreatedDateTime) {
return ssCreatedDateTime;
}
if (key == IdCreationOptions) {
return ssCreationOptions;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdDisplayName) {
return ssDisplayName;
}
if (key == IdExpirationDateTime) {
return ssExpirationDateTime;
}
if (key == IdGroupTypes) {
return ssGroupTypes;
}
if (key == IdMail) {
return ssMail;
}
if (key == IdMailEnabled) {
return ssMailEnabled;
}
if (key == IdMailNickname) {
return ssMailNickname;
}
if (key == IdMembershipRule) {
return ssMembershipRule;
}
if (key == IdMembershipRuleProcessingState) {
return ssMembershipRuleProcessingState;
}
if (key == IdProxyAddresses) {
return ssProxyAddresses;
}
if (key == IdRenewedDateTime) {
return ssRenewedDateTime;
}
if (key == IdResourceBehaviorOptions) {
return ssResourceBehaviorOptions;
}
if (key == IdResourceProvisioningOptions) {
return ssResourceProvisioningOptions;
}
if (key == IdSecurityEnabled) {
return ssSecurityEnabled;
}
if (key == IdSecurityIdentifier) {
return ssSecurityIdentifier;
}
if (key == IdVisibility) {
return ssVisibility;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdCreatedDateTime.Key.AsGuid) {
return ssCreatedDateTime;
}
if (attributeKey == IdCreationOptions.Key.AsGuid) {
return ssCreationOptions;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdDisplayName.Key.AsGuid) {
return ssDisplayName;
}
if (attributeKey == IdExpirationDateTime.Key.AsGuid) {
return ssExpirationDateTime;
}
if (attributeKey == IdGroupTypes.Key.AsGuid) {
return ssGroupTypes;
}
if (attributeKey == IdMail.Key.AsGuid) {
return ssMail;
}
if (attributeKey == IdMailEnabled.Key.AsGuid) {
return ssMailEnabled;
}
if (attributeKey == IdMailNickname.Key.AsGuid) {
return ssMailNickname;
}
if (attributeKey == IdMembershipRule.Key.AsGuid) {
return ssMembershipRule;
}
if (attributeKey == IdMembershipRuleProcessingState.Key.AsGuid) {
return ssMembershipRuleProcessingState;
}
if (attributeKey == IdProxyAddresses.Key.AsGuid) {
return ssProxyAddresses;
}
if (attributeKey == IdRenewedDateTime.Key.AsGuid) {
return ssRenewedDateTime;
}
if (attributeKey == IdResourceBehaviorOptions.Key.AsGuid) {
return ssResourceBehaviorOptions;
}
if (attributeKey == IdResourceProvisioningOptions.Key.AsGuid) {
return ssResourceProvisioningOptions;
}
if (attributeKey == IdSecurityEnabled.Key.AsGuid) {
return ssSecurityEnabled;
}
if (attributeKey == IdSecurityIdentifier.Key.AsGuid) {
return ssSecurityIdentifier;
}
if (attributeKey == IdVisibility.Key.AsGuid) {
return ssVisibility;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ssCreatedDateTime = (DateTime) other.AttributeGet(IdCreatedDateTime);
ssCreationOptions = new BasicTypeList<string>();
ssCreationOptions.FillFromOther((IOSList) other.AttributeGet(IdCreationOptions));
ssDescription = (string) other.AttributeGet(IdDescription);
ssDisplayName = (string) other.AttributeGet(IdDisplayName);
ssExpirationDateTime = (DateTime) other.AttributeGet(IdExpirationDateTime);
ssGroupTypes = new BasicTypeList<string>();
ssGroupTypes.FillFromOther((IOSList) other.AttributeGet(IdGroupTypes));
ssMail = (string) other.AttributeGet(IdMail);
ssMailEnabled = (bool) other.AttributeGet(IdMailEnabled);
ssMailNickname = (string) other.AttributeGet(IdMailNickname);
ssMembershipRule = (string) other.AttributeGet(IdMembershipRule);
ssMembershipRuleProcessingState = (string) other.AttributeGet(IdMembershipRuleProcessingState);
ssProxyAddresses = new BasicTypeList<string>();
ssProxyAddresses.FillFromOther((IOSList) other.AttributeGet(IdProxyAddresses));
ssRenewedDateTime = (DateTime) other.AttributeGet(IdRenewedDateTime);
ssResourceBehaviorOptions = new BasicTypeList<string>();
ssResourceBehaviorOptions.FillFromOther((IOSList) other.AttributeGet(IdResourceBehaviorOptions));
ssResourceProvisioningOptions = new BasicTypeList<string>();
ssResourceProvisioningOptions.FillFromOther((IOSList) other.AttributeGet(IdResourceProvisioningOptions));
ssSecurityEnabled = (bool) other.AttributeGet(IdSecurityEnabled);
ssSecurityIdentifier = (string) other.AttributeGet(IdSecurityIdentifier);
ssVisibility = (string) other.AttributeGet(IdVisibility);
}
} // ST_7d9cb56357295234b770124829cebf1bStructure
/// <summary>
/// RecordList type <code>ValueItem2List</code> that represents a record list of
///  <code>ValueItem2</code>
/// </summary>
public partial class RL_ae05fe34dabbae8c8aefa197aab938f8 : GenericRecordList<ST_7d9cb56357295234b770124829cebf1bStructure>, IEnumerable, IEnumerator {

protected override ST_7d9cb56357295234b770124829cebf1bStructure GetElementDefaultValue() {
return new ST_7d9cb56357295234b770124829cebf1bStructure();
}

public T[] ToArray<T>(Func<ST_7d9cb56357295234b770124829cebf1bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ae05fe34dabbae8c8aefa197aab938f8 recordList, Func<ST_7d9cb56357295234b770124829cebf1bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ae05fe34dabbae8c8aefa197aab938f8(ST_7d9cb56357295234b770124829cebf1bStructure[] array) {
  RL_ae05fe34dabbae8c8aefa197aab938f8 result = new RL_ae05fe34dabbae8c8aefa197aab938f8();
result.InnerFromArray(array);
    return result;
}

public static RL_ae05fe34dabbae8c8aefa197aab938f8 ToList<T>(T[] array, Func <T, ST_7d9cb56357295234b770124829cebf1bStructure> converter) {
  RL_ae05fe34dabbae8c8aefa197aab938f8 result = new RL_ae05fe34dabbae8c8aefa197aab938f8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ae05fe34dabbae8c8aefa197aab938f8 FromRestList<T>(RestList<T> restList, Func <T, ST_7d9cb56357295234b770124829cebf1bStructure> converter) {
  RL_ae05fe34dabbae8c8aefa197aab938f8 result = new RL_ae05fe34dabbae8c8aefa197aab938f8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ae05fe34dabbae8c8aefa197aab938f8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7d9cb56357295234b770124829cebf1bStructure> NewList() {
return new RL_ae05fe34dabbae8c8aefa197aab938f8();
}


} // RL_ae05fe34dabbae8c8aefa197aab938f8
}

