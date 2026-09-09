using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceFile (Zc72Ki7NyES3xUdyKBgdfQ)
///  <code>EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord</code> that represent
/// s <code>InvoiceFile</code> <p>Description: Entity that holds Invoice Files</p>
/// </summary>
// Name: InvoiceFile
public partial struct EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord : ITypedRecord<EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EHwRjS_I20OL_Ow_GSLSlQ");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*h11Yo1o4tkCMyLRsQdkXAw");
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*X_hKWUopGU6TM_HWaLYnag");
internal static readonly GlobalObjectKey IdIsExtra = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*C+ZuvVxLdUCNeKJNob0tiQ");
internal static readonly GlobalObjectKey IdIsReport = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5Kbk5s6Ylku1E1RmpKDQ9Q");
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*85+p3Zovw0ORQgwhor87IA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6+biNV+bzkSf6XHtWZiNpA");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GUfx95HUikK9O7wzS6+z3A");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(8,true);
          _ssId = value;
      }
  }
}

private long _ssInvoiceId;
public long ssInvoiceId{
  get{
      return _ssInvoiceId;
  }
  set{
      if((_ssInvoiceId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInvoiceId = value;
      }
  }
}

private string _ssFilename;
public string ssFilename{
  get{
      return _ssFilename;
  }
  set{
      if((_ssFilename!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssFilename = value;
      }
  }
}

private bool _ssIsExtra;
public bool ssIsExtra{
  get{
      return _ssIsExtra;
  }
  set{
      if((_ssIsExtra!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssIsExtra = value;
      }
  }
}

private bool _ssIsReport;
public bool ssIsReport{
  get{
      return _ssIsReport;
  }
  set{
      if((_ssIsReport!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssIsReport = value;
      }
  }
}

private long _ssStorageId;
public long ssStorageId{
  get{
      return _ssStorageId;
  }
  set{
      if((_ssStorageId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssStorageId = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssCreatedBy = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssCreatedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssInvoiceId = 0L;
_ssFilename = "";
_ssIsExtra = false;
_ssIsReport = false;
_ssStorageId = 0L;
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssId = r.ReadLongInteger(index++, "InvoiceFile.Id", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceFile.InvoiceId", 0L);
ssFilename = r.ReadText(index++, "InvoiceFile.Filename", "");
ssIsExtra = r.ReadBoolean(index++, "InvoiceFile.IsExtra", false);
ssIsReport = r.ReadBoolean(index++, "InvoiceFile.IsReport", false);
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "InvoiceFile.StorageId", 0L);
ssCreatedBy = r.ReadEntityReferenceText(index++, "InvoiceFile.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "InvoiceFile.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ChangedAttributes = new BitArray(8,false);
OptimizedAttributes = new BitArray(8,false);
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
public void ReadIM(EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord r) {
this = r;
}


public static bool operator == (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord a, EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssFilename != b.ssFilename) return false;
if (a.ssIsExtra != b.ssIsExtra) return false;
if (a.ssIsReport != b.ssIsReport) return false;
if (a.ssStorageId != b.ssStorageId) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
return true;
}

public static bool operator != (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord a, EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord)) return false;
return (this == (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssIsExtra.GetHashCode()
 ^ ssIsReport.GetHashCode()
 ^ ssStorageId.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord Duplicate() {
EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceId = this._ssInvoiceId;
t._ssFilename = this._ssFilename;
t._ssIsExtra = this._ssIsExtra;
t._ssIsReport = this._ssIsReport;
t._ssStorageId = this._ssStorageId;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t.ChangedAttributes = new BitArray(8);
t.OptimizedAttributes = new BitArray(8);
for(int i = 0; i < 8; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
} else if (head == "isreport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsReport")) variable.Value = ssIsReport; else variable.Optimized = true;
} else if (head == "storageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageId")) variable.Value = ssStorageId; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdInvoiceId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdFilename)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIsExtra)) {
return ChangedAttributes[3];
}
if (key.Equals(IdIsReport)) {
return ChangedAttributes[4];
}
if (key.Equals(IdStorageId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[6];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[7];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdInvoiceId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdFilename)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIsExtra)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdIsReport)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdStorageId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[7];
}
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
if (key == IdIsReport) {
return ssIsReport;
}
if (key == IdStorageId) {
return ssStorageId;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
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
if (attributeKey == IdIsReport.Key.AsGuid) {
return ssIsReport;
}
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(8);
OptimizedAttributes = new BitArray(8);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceId);
ssFilename = (string) other.AttributeGet(IdFilename);
ChangedAttributes[2] = other.ChangedAttributeGet(IdFilename);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdFilename);
ssIsExtra = (bool) other.AttributeGet(IdIsExtra);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIsExtra);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsExtra);
ssIsReport = (bool) other.AttributeGet(IdIsReport);
ChangedAttributes[4] = other.ChangedAttributeGet(IdIsReport);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdIsReport);
ssStorageId = (long) other.AttributeGet(IdStorageId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdStorageId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdStorageId);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[6] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[7] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdCreatedOn);
}
} // EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord

/// <summary>
/// RecordList type <code>InvoiceFileList</code> that represents a record list of
///  <code>InvoiceFile</code>
/// </summary>
public partial class RL_4008a325a41a873df85c8da3f049c5e8 : GenericRecordList<EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord>, IEnumerable, IEnumerator {

protected override EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord GetElementDefaultValue() {
return new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
}

public T[] ToArray<T>(Func<EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4008a325a41a873df85c8da3f049c5e8 recordList, Func<EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4008a325a41a873df85c8da3f049c5e8(EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord[] array) {
  RL_4008a325a41a873df85c8da3f049c5e8 result = new RL_4008a325a41a873df85c8da3f049c5e8();
result.InnerFromArray(array);
    return result;
}

public static RL_4008a325a41a873df85c8da3f049c5e8 ToList<T>(T[] array, Func <T, EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord> converter) {
  RL_4008a325a41a873df85c8da3f049c5e8 result = new RL_4008a325a41a873df85c8da3f049c5e8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4008a325a41a873df85c8da3f049c5e8 FromRestList<T>(RestList<T> restList, Func <T, EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord> converter) {
  RL_4008a325a41a873df85c8da3f049c5e8 result = new RL_4008a325a41a873df85c8da3f049c5e8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4008a325a41a873df85c8da3f049c5e8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord> NewList() {
return new RL_4008a325a41a873df85c8da3f049c5e8();
}


} // RL_4008a325a41a873df85c8da3f049c5e8
}
