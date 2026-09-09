namespace ssConectaProveedores {
/// <summary>
/// [Structure] InvoiceAuditFilesList (Wt4X8Lj7HUaNafO_m77skQ)
///  <code>ST_15467825cb087ac1591b96b0d1989badStructure</code> that represent
/// s <code>InvoiceAuditFilesList</code> <p>Description: </p>
/// </summary>
// Name: InvoiceAuditFilesList
public partial struct ST_15467825cb087ac1591b96b0d1989badStructure : ITypedRecord<ST_15467825cb087ac1591b96b0d1989badStructure> {
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jQQYNHSX9Uu+jSIoOJPtwg");
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vIn08A0KcE227q1DAP91Mw");
internal static readonly GlobalObjectKey IdIsExtra = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yJfs1mV5GUulWkkLSZGN0g");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*o+SnjBjCIE6JvB5BXhUK_w");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QciD3l5zukmvWA7nzB6M8Q");
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*cbqTqrrZWUCDejE8cBsmoA");
internal static readonly GlobalObjectKey IdStorageSize = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WEH6GyHUukyvu+STgu4bjQ");
internal static readonly GlobalObjectKey IdUserName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HNcCpHsccEu0NMJFcCXk3A");

public bool ssIsSelected;

public string ssFilename;

public bool ssIsExtra;

public string ssCreatedBy;

public DateTime ssCreatedOn;

public long ssStorageId;

public long ssStorageSize;

public string ssUserName;


public BitArray OptimizedAttributes;

public ST_15467825cb087ac1591b96b0d1989badStructure() {
OptimizedAttributes = null;
ssIsSelected = false;
ssFilename = "";
ssIsExtra = false;
ssCreatedBy = "";
ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssStorageId = 0L;
ssStorageSize = 0L;
ssUserName = "";
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
ssIsSelected = r.ReadBoolean(index++, "InvoiceAuditFilesList.IsSelected", false);
ssFilename = r.ReadText(index++, "InvoiceAuditFilesList.Filename", "");
ssIsExtra = r.ReadBoolean(index++, "InvoiceAuditFilesList.IsExtra", false);
ssCreatedBy = r.ReadText(index++, "InvoiceAuditFilesList.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "InvoiceAuditFilesList.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAuditFilesList.StorageId", 0L);
ssStorageSize = r.ReadLongInteger(index++, "InvoiceAuditFilesList.StorageSize", 0L);
ssUserName = r.ReadText(index++, "InvoiceAuditFilesList.UserName", "");
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
public void ReadIM(ST_15467825cb087ac1591b96b0d1989badStructure r) {
this = r;
}


public static bool operator == (ST_15467825cb087ac1591b96b0d1989badStructure a, ST_15467825cb087ac1591b96b0d1989badStructure b) {
if (a.ssIsSelected != b.ssIsSelected) return false;
if (a.ssFilename != b.ssFilename) return false;
if (a.ssIsExtra != b.ssIsExtra) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssStorageId != b.ssStorageId) return false;
if (a.ssStorageSize != b.ssStorageSize) return false;
if (a.ssUserName != b.ssUserName) return false;
return true;
}

public static bool operator != (ST_15467825cb087ac1591b96b0d1989badStructure a, ST_15467825cb087ac1591b96b0d1989badStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_15467825cb087ac1591b96b0d1989badStructure)) return false;
return (this == (ST_15467825cb087ac1591b96b0d1989badStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIsSelected.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssIsExtra.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssStorageId.GetHashCode()
 ^ ssStorageSize.GetHashCode()
 ^ ssUserName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_15467825cb087ac1591b96b0d1989badStructure Duplicate() {
ST_15467825cb087ac1591b96b0d1989badStructure t;
t.ssIsSelected = this.ssIsSelected;
t.ssFilename = this.ssFilename;
t.ssIsExtra = this.ssIsExtra;
t.ssCreatedBy = this.ssCreatedBy;
t.ssCreatedOn = this.ssCreatedOn;
t.ssStorageId = this.ssStorageId;
t.ssStorageSize = this.ssStorageSize;
t.ssUserName = this.ssUserName;
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
if (head == "isselected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSelected")) variable.Value = ssIsSelected; else variable.Optimized = true;
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Filename")) variable.Value = ssFilename; else variable.Optimized = true;
} else if (head == "isextra") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsExtra")) variable.Value = ssIsExtra; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "storageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageId")) variable.Value = ssStorageId; else variable.Optimized = true;
} else if (head == "storagesize") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageSize")) variable.Value = ssStorageSize; else variable.Optimized = true;
} else if (head == "username") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserName")) variable.Value = ssUserName; else variable.Optimized = true;
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
if (key == IdIsSelected) {
return ssIsSelected;
}
if (key == IdFilename) {
return ssFilename;
}
if (key == IdIsExtra) {
return ssIsExtra;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdStorageId) {
return ssStorageId;
}
if (key == IdStorageSize) {
return ssStorageSize;
}
if (key == IdUserName) {
return ssUserName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIsSelected.Key.AsGuid) {
return ssIsSelected;
}
if (attributeKey == IdFilename.Key.AsGuid) {
return ssFilename;
}
if (attributeKey == IdIsExtra.Key.AsGuid) {
return ssIsExtra;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
}
if (attributeKey == IdStorageSize.Key.AsGuid) {
return ssStorageSize;
}
if (attributeKey == IdUserName.Key.AsGuid) {
return ssUserName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
ssFilename = (string) other.AttributeGet(IdFilename);
ssIsExtra = (bool) other.AttributeGet(IdIsExtra);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ssStorageId = (long) other.AttributeGet(IdStorageId);
ssStorageSize = (long) other.AttributeGet(IdStorageSize);
ssUserName = (string) other.AttributeGet(IdUserName);
}
} // ST_15467825cb087ac1591b96b0d1989badStructure
/// <summary>
/// RecordList type <code>InvoiceAuditFilesListList</code> that represents a record list of
///  <code>InvoiceAuditFilesList</code>
/// </summary>
public partial class RL_5582607f6208069586dcaff23f9c5144 : GenericRecordList<ST_15467825cb087ac1591b96b0d1989badStructure>, IEnumerable, IEnumerator {

protected override ST_15467825cb087ac1591b96b0d1989badStructure GetElementDefaultValue() {
return new ST_15467825cb087ac1591b96b0d1989badStructure();
}

public T[] ToArray<T>(Func<ST_15467825cb087ac1591b96b0d1989badStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5582607f6208069586dcaff23f9c5144 recordList, Func<ST_15467825cb087ac1591b96b0d1989badStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5582607f6208069586dcaff23f9c5144(ST_15467825cb087ac1591b96b0d1989badStructure[] array) {
  RL_5582607f6208069586dcaff23f9c5144 result = new RL_5582607f6208069586dcaff23f9c5144();
result.InnerFromArray(array);
    return result;
}

public static RL_5582607f6208069586dcaff23f9c5144 ToList<T>(T[] array, Func <T, ST_15467825cb087ac1591b96b0d1989badStructure> converter) {
  RL_5582607f6208069586dcaff23f9c5144 result = new RL_5582607f6208069586dcaff23f9c5144();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5582607f6208069586dcaff23f9c5144 FromRestList<T>(RestList<T> restList, Func <T, ST_15467825cb087ac1591b96b0d1989badStructure> converter) {
  RL_5582607f6208069586dcaff23f9c5144 result = new RL_5582607f6208069586dcaff23f9c5144();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5582607f6208069586dcaff23f9c5144() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_15467825cb087ac1591b96b0d1989badStructure> NewList() {
return new RL_5582607f6208069586dcaff23f9c5144();
}


} // RL_5582607f6208069586dcaff23f9c5144
}

