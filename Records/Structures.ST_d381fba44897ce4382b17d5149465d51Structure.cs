namespace ssConectaProveedores {
/// <summary>
/// [Structure] InvoiceFiles (2tN5sPiE7UGZq3Wi_V2R3A)
///  <code>ST_d381fba44897ce4382b17d5149465d51Structure</code> that represents <code>InvoiceFiles</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceFiles
public partial struct ST_d381fba44897ce4382b17d5149465d51Structure : ITypedRecord<ST_d381fba44897ce4382b17d5149465d51Structure> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zcFp4jPvi0K4Nw414MwAqw");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*cKTivU7SekqbBk6qS89SZQ");
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0Jv5iZ64VE2Y5JKFvuSiBg");
internal static readonly GlobalObjectKey IdIsExtra = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*CvjvGcWDq0q8DQNXtAd1_w");
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6mGfEhXyqkCAEWAGZu3uhA");
internal static readonly GlobalObjectKey IdCreatedByName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tBZ51YqiZEeMoMPbGkYyfg");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*63GgIoB8g0SoiGVx0rMi1Q");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xxMclbGr_0auGfG3JI9xoQ");
internal static readonly GlobalObjectKey IdInvoiceStatusLabel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BcVLmOOkVky1HswoIKVLpg");
internal static readonly GlobalObjectKey IdInvoiceStatusClass = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*iXdpGGixSEC7wSrrX_lhGg");
internal static readonly GlobalObjectKey IdSize = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7ZUUyexG2kO1O99kBta13w");

public long ssId;

public long ssInvoiceId;

public string ssFilename;

public bool ssIsExtra;

public long ssStorageId;

public string ssCreatedByName;

public string ssCreatedBy;

public DateTime ssCreatedOn;

public string ssInvoiceStatusLabel;

public string ssInvoiceStatusClass;

public long ssSize;


public BitArray OptimizedAttributes;

public ST_d381fba44897ce4382b17d5149465d51Structure() {
OptimizedAttributes = null;
ssId = 0L;
ssInvoiceId = 0L;
ssFilename = "";
ssIsExtra = false;
ssStorageId = 0L;
ssCreatedByName = "";
ssCreatedBy = "";
ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssInvoiceStatusLabel = "";
ssInvoiceStatusClass = "";
ssSize = 0L;
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
ssId = r.ReadLongInteger(index++, "InvoiceFiles.Id", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceFiles.InvoiceId", 0L);
ssFilename = r.ReadText(index++, "InvoiceFiles.Filename", "");
ssIsExtra = r.ReadBoolean(index++, "InvoiceFiles.IsExtra", false);
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "InvoiceFiles.StorageId", 0L);
ssCreatedByName = r.ReadText(index++, "InvoiceFiles.CreatedByName", "");
ssCreatedBy = r.ReadEntityReferenceText(index++, "InvoiceFiles.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "InvoiceFiles.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssInvoiceStatusLabel = r.ReadText(index++, "InvoiceFiles.InvoiceStatusLabel", "");
ssInvoiceStatusClass = r.ReadText(index++, "InvoiceFiles.InvoiceStatusClass", "");
ssSize = r.ReadLongInteger(index++, "InvoiceFiles.Size", 0L);
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
public void ReadIM(ST_d381fba44897ce4382b17d5149465d51Structure r) {
this = r;
}


public static bool operator == (ST_d381fba44897ce4382b17d5149465d51Structure a, ST_d381fba44897ce4382b17d5149465d51Structure b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssFilename != b.ssFilename) return false;
if (a.ssIsExtra != b.ssIsExtra) return false;
if (a.ssStorageId != b.ssStorageId) return false;
if (a.ssCreatedByName != b.ssCreatedByName) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssInvoiceStatusLabel != b.ssInvoiceStatusLabel) return false;
if (a.ssInvoiceStatusClass != b.ssInvoiceStatusClass) return false;
if (a.ssSize != b.ssSize) return false;
return true;
}

public static bool operator != (ST_d381fba44897ce4382b17d5149465d51Structure a, ST_d381fba44897ce4382b17d5149465d51Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_d381fba44897ce4382b17d5149465d51Structure)) return false;
return (this == (ST_d381fba44897ce4382b17d5149465d51Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssIsExtra.GetHashCode()
 ^ ssStorageId.GetHashCode()
 ^ ssCreatedByName.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssInvoiceStatusLabel.GetHashCode()
 ^ ssInvoiceStatusClass.GetHashCode()
 ^ ssSize.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_d381fba44897ce4382b17d5149465d51Structure Duplicate() {
ST_d381fba44897ce4382b17d5149465d51Structure t;
t.ssId = this.ssId;
t.ssInvoiceId = this.ssInvoiceId;
t.ssFilename = this.ssFilename;
t.ssIsExtra = this.ssIsExtra;
t.ssStorageId = this.ssStorageId;
t.ssCreatedByName = this.ssCreatedByName;
t.ssCreatedBy = this.ssCreatedBy;
t.ssCreatedOn = this.ssCreatedOn;
t.ssInvoiceStatusLabel = this.ssInvoiceStatusLabel;
t.ssInvoiceStatusClass = this.ssInvoiceStatusClass;
t.ssSize = this.ssSize;
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
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Filename")) variable.Value = ssFilename; else variable.Optimized = true;
} else if (head == "isextra") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsExtra")) variable.Value = ssIsExtra; else variable.Optimized = true;
} else if (head == "storageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageId")) variable.Value = ssStorageId; else variable.Optimized = true;
} else if (head == "createdbyname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedByName")) variable.Value = ssCreatedByName; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "invoicestatuslabel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatusLabel")) variable.Value = ssInvoiceStatusLabel; else variable.Optimized = true;
} else if (head == "invoicestatusclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatusClass")) variable.Value = ssInvoiceStatusClass; else variable.Optimized = true;
} else if (head == "size") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Size")) variable.Value = ssSize; else variable.Optimized = true;
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
if (key == IdInvoiceId) {
return ssInvoiceId;
}
if (key == IdFilename) {
return ssFilename;
}
if (key == IdIsExtra) {
return ssIsExtra;
}
if (key == IdStorageId) {
return ssStorageId;
}
if (key == IdCreatedByName) {
return ssCreatedByName;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdInvoiceStatusLabel) {
return ssInvoiceStatusLabel;
}
if (key == IdInvoiceStatusClass) {
return ssInvoiceStatusClass;
}
if (key == IdSize) {
return ssSize;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdFilename.Key.AsGuid) {
return ssFilename;
}
if (attributeKey == IdIsExtra.Key.AsGuid) {
return ssIsExtra;
}
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
}
if (attributeKey == IdCreatedByName.Key.AsGuid) {
return ssCreatedByName;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdInvoiceStatusLabel.Key.AsGuid) {
return ssInvoiceStatusLabel;
}
if (attributeKey == IdInvoiceStatusClass.Key.AsGuid) {
return ssInvoiceStatusClass;
}
if (attributeKey == IdSize.Key.AsGuid) {
return ssSize;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ssFilename = (string) other.AttributeGet(IdFilename);
ssIsExtra = (bool) other.AttributeGet(IdIsExtra);
ssStorageId = (long) other.AttributeGet(IdStorageId);
ssCreatedByName = (string) other.AttributeGet(IdCreatedByName);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ssInvoiceStatusLabel = (string) other.AttributeGet(IdInvoiceStatusLabel);
ssInvoiceStatusClass = (string) other.AttributeGet(IdInvoiceStatusClass);
ssSize = (long) other.AttributeGet(IdSize);
}
} // ST_d381fba44897ce4382b17d5149465d51Structure
/// <summary>
/// RecordList type <code>InvoiceFilesList</code> that represents a record list of
///  <code>InvoiceFiles</code>
/// </summary>
public partial class RL_cc11123f1ba1bfd417e2f33be28138e9 : GenericRecordList<ST_d381fba44897ce4382b17d5149465d51Structure>, IEnumerable, IEnumerator {

protected override ST_d381fba44897ce4382b17d5149465d51Structure GetElementDefaultValue() {
return new ST_d381fba44897ce4382b17d5149465d51Structure();
}

public T[] ToArray<T>(Func<ST_d381fba44897ce4382b17d5149465d51Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cc11123f1ba1bfd417e2f33be28138e9 recordList, Func<ST_d381fba44897ce4382b17d5149465d51Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cc11123f1ba1bfd417e2f33be28138e9(ST_d381fba44897ce4382b17d5149465d51Structure[] array) {
  RL_cc11123f1ba1bfd417e2f33be28138e9 result = new RL_cc11123f1ba1bfd417e2f33be28138e9();
result.InnerFromArray(array);
    return result;
}

public static RL_cc11123f1ba1bfd417e2f33be28138e9 ToList<T>(T[] array, Func <T, ST_d381fba44897ce4382b17d5149465d51Structure> converter) {
  RL_cc11123f1ba1bfd417e2f33be28138e9 result = new RL_cc11123f1ba1bfd417e2f33be28138e9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cc11123f1ba1bfd417e2f33be28138e9 FromRestList<T>(RestList<T> restList, Func <T, ST_d381fba44897ce4382b17d5149465d51Structure> converter) {
  RL_cc11123f1ba1bfd417e2f33be28138e9 result = new RL_cc11123f1ba1bfd417e2f33be28138e9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cc11123f1ba1bfd417e2f33be28138e9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_d381fba44897ce4382b17d5149465d51Structure> NewList() {
return new RL_cc11123f1ba1bfd417e2f33be28138e9();
}


} // RL_cc11123f1ba1bfd417e2f33be28138e9
}

