using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] FileExtended (iZaeJdSRD0CO2yJ7pf+lpQ)
///  <code>EN_dcebdd8ba305133f41b1e1804925997fEntityRecord</code> that represent
/// s <code>FileExtended</code> <p>Description: Entity that extends file entity.</p>
/// </summary>
// Name: FileExtended
public partial struct EN_dcebdd8ba305133f41b1e1804925997fEntityRecord : ITypedRecord<EN_dcebdd8ba305133f41b1e1804925997fEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Fl7vcCR28UCUnC_erWtzBg");
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nFlWzLdK5kmLbRq81pMclg");
internal static readonly GlobalObjectKey IdIsProcessed = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Iunt7Oxmy0G6VwBO667sbQ");
internal static readonly GlobalObjectKey IdHasError = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*flOA7DZRv0GLH39aMKd5sQ");
internal static readonly GlobalObjectKey IdErrorMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IiiuZM1rzEq1PJVjpjFPMQ");
internal static readonly GlobalObjectKey IdUploadedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*U2Xz4WzklES4Uty9aTfSTw");
internal static readonly GlobalObjectKey IdUploadedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1EJ3s_78l0egecJKbAK9lw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(7,true);
          _ssId = value;
      }
  }
}

private string _ssFilename;
public string ssFilename{
  get{
      return _ssFilename;
  }
  set{
      if((_ssFilename!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssFilename = value;
      }
  }
}

private bool _ssIsProcessed;
public bool ssIsProcessed{
  get{
      return _ssIsProcessed;
  }
  set{
      if((_ssIsProcessed!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssIsProcessed = value;
      }
  }
}

private bool _ssHasError;
public bool ssHasError{
  get{
      return _ssHasError;
  }
  set{
      if((_ssHasError!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssHasError = value;
      }
  }
}

private string _ssErrorMessage;
public string ssErrorMessage{
  get{
      return _ssErrorMessage;
  }
  set{
      if((_ssErrorMessage!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssErrorMessage = value;
      }
  }
}

private string _ssUploadedBy;
public string ssUploadedBy{
  get{
      return _ssUploadedBy;
  }
  set{
      if((_ssUploadedBy!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssUploadedBy = value;
      }
  }
}

private DateTime _ssUploadedOn;
public DateTime ssUploadedOn{
  get{
      return _ssUploadedOn;
  }
  set{
      if((_ssUploadedOn!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssUploadedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_dcebdd8ba305133f41b1e1804925997fEntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssFilename = "";
_ssIsProcessed = false;
_ssHasError = false;
_ssErrorMessage = "";
_ssUploadedBy = "";
_ssUploadedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssId = r.ReadEntityReferenceLongInteger(index++, "FileExtended.Id", 0L);
ssFilename = r.ReadText(index++, "FileExtended.Filename", "");
ssIsProcessed = r.ReadBoolean(index++, "FileExtended.IsProcessed", false);
ssHasError = r.ReadBoolean(index++, "FileExtended.HasError", false);
ssErrorMessage = r.ReadText(index++, "FileExtended.ErrorMessage", "");
ssUploadedBy = r.ReadEntityReferenceText(index++, "FileExtended.UploadedBy", "");
ssUploadedOn = r.ReadDateTime(index++, "FileExtended.UploadedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ChangedAttributes = new BitArray(7,false);
OptimizedAttributes = new BitArray(7,false);
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
public void ReadIM(EN_dcebdd8ba305133f41b1e1804925997fEntityRecord r) {
this = r;
}


public static bool operator == (EN_dcebdd8ba305133f41b1e1804925997fEntityRecord a, EN_dcebdd8ba305133f41b1e1804925997fEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssFilename != b.ssFilename) return false;
if (a.ssIsProcessed != b.ssIsProcessed) return false;
if (a.ssHasError != b.ssHasError) return false;
if (a.ssErrorMessage != b.ssErrorMessage) return false;
if (a.ssUploadedBy != b.ssUploadedBy) return false;
if (a.ssUploadedOn != b.ssUploadedOn) return false;
return true;
}

public static bool operator != (EN_dcebdd8ba305133f41b1e1804925997fEntityRecord a, EN_dcebdd8ba305133f41b1e1804925997fEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_dcebdd8ba305133f41b1e1804925997fEntityRecord)) return false;
return (this == (EN_dcebdd8ba305133f41b1e1804925997fEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssIsProcessed.GetHashCode()
 ^ ssHasError.GetHashCode()
 ^ ssErrorMessage.GetHashCode()
 ^ ssUploadedBy.GetHashCode()
 ^ ssUploadedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_dcebdd8ba305133f41b1e1804925997fEntityRecord Duplicate() {
EN_dcebdd8ba305133f41b1e1804925997fEntityRecord t;
t._ssId = this._ssId;
t._ssFilename = this._ssFilename;
t._ssIsProcessed = this._ssIsProcessed;
t._ssHasError = this._ssHasError;
t._ssErrorMessage = this._ssErrorMessage;
t._ssUploadedBy = this._ssUploadedBy;
t._ssUploadedOn = this._ssUploadedOn;
t.ChangedAttributes = new BitArray(7);
t.OptimizedAttributes = new BitArray(7);
for(int i = 0; i < 7; i++){
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
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Filename")) variable.Value = ssFilename; else variable.Optimized = true;
} else if (head == "isprocessed") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsProcessed")) variable.Value = ssIsProcessed; else variable.Optimized = true;
} else if (head == "haserror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasError")) variable.Value = ssHasError; else variable.Optimized = true;
} else if (head == "errormessage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ErrorMessage")) variable.Value = ssErrorMessage; else variable.Optimized = true;
} else if (head == "uploadedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UploadedBy")) variable.Value = ssUploadedBy; else variable.Optimized = true;
} else if (head == "uploadedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UploadedOn")) variable.Value = ssUploadedOn; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdFilename)) {
return ChangedAttributes[1];
}
if (key.Equals(IdIsProcessed)) {
return ChangedAttributes[2];
}
if (key.Equals(IdHasError)) {
return ChangedAttributes[3];
}
if (key.Equals(IdErrorMessage)) {
return ChangedAttributes[4];
}
if (key.Equals(IdUploadedBy)) {
return ChangedAttributes[5];
}
if (key.Equals(IdUploadedOn)) {
return ChangedAttributes[6];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdFilename)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdIsProcessed)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdHasError)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdErrorMessage)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdUploadedBy)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdUploadedOn)) {
return OptimizedAttributes[6];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdFilename) {
return ssFilename;
}
if (key == IdIsProcessed) {
return ssIsProcessed;
}
if (key == IdHasError) {
return ssHasError;
}
if (key == IdErrorMessage) {
return ssErrorMessage;
}
if (key == IdUploadedBy) {
return ssUploadedBy;
}
if (key == IdUploadedOn) {
return ssUploadedOn;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdFilename.Key.AsGuid) {
return ssFilename;
}
if (attributeKey == IdIsProcessed.Key.AsGuid) {
return ssIsProcessed;
}
if (attributeKey == IdHasError.Key.AsGuid) {
return ssHasError;
}
if (attributeKey == IdErrorMessage.Key.AsGuid) {
return ssErrorMessage;
}
if (attributeKey == IdUploadedBy.Key.AsGuid) {
return ssUploadedBy;
}
if (attributeKey == IdUploadedOn.Key.AsGuid) {
return ssUploadedOn;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(7);
OptimizedAttributes = new BitArray(7);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssFilename = (string) other.AttributeGet(IdFilename);
ChangedAttributes[1] = other.ChangedAttributeGet(IdFilename);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdFilename);
ssIsProcessed = (bool) other.AttributeGet(IdIsProcessed);
ChangedAttributes[2] = other.ChangedAttributeGet(IdIsProcessed);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdIsProcessed);
ssHasError = (bool) other.AttributeGet(IdHasError);
ChangedAttributes[3] = other.ChangedAttributeGet(IdHasError);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdHasError);
ssErrorMessage = (string) other.AttributeGet(IdErrorMessage);
ChangedAttributes[4] = other.ChangedAttributeGet(IdErrorMessage);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdErrorMessage);
ssUploadedBy = (string) other.AttributeGet(IdUploadedBy);
ChangedAttributes[5] = other.ChangedAttributeGet(IdUploadedBy);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdUploadedBy);
ssUploadedOn = (DateTime) other.AttributeGet(IdUploadedOn);
ChangedAttributes[6] = other.ChangedAttributeGet(IdUploadedOn);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdUploadedOn);
}
} // EN_dcebdd8ba305133f41b1e1804925997fEntityRecord

/// <summary>
/// RecordList type <code>FileExtendedList</code> that represents a record list of
///  <code>FileExtended</code>
/// </summary>
public partial class RL_c104fec8109b869a2990c6a6e0245842 : GenericRecordList<EN_dcebdd8ba305133f41b1e1804925997fEntityRecord>, IEnumerable, IEnumerator {

protected override EN_dcebdd8ba305133f41b1e1804925997fEntityRecord GetElementDefaultValue() {
return new EN_dcebdd8ba305133f41b1e1804925997fEntityRecord();
}

public T[] ToArray<T>(Func<EN_dcebdd8ba305133f41b1e1804925997fEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c104fec8109b869a2990c6a6e0245842 recordList, Func<EN_dcebdd8ba305133f41b1e1804925997fEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c104fec8109b869a2990c6a6e0245842(EN_dcebdd8ba305133f41b1e1804925997fEntityRecord[] array) {
  RL_c104fec8109b869a2990c6a6e0245842 result = new RL_c104fec8109b869a2990c6a6e0245842();
result.InnerFromArray(array);
    return result;
}

public static RL_c104fec8109b869a2990c6a6e0245842 ToList<T>(T[] array, Func <T, EN_dcebdd8ba305133f41b1e1804925997fEntityRecord> converter) {
  RL_c104fec8109b869a2990c6a6e0245842 result = new RL_c104fec8109b869a2990c6a6e0245842();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c104fec8109b869a2990c6a6e0245842 FromRestList<T>(RestList<T> restList, Func <T, EN_dcebdd8ba305133f41b1e1804925997fEntityRecord> converter) {
  RL_c104fec8109b869a2990c6a6e0245842 result = new RL_c104fec8109b869a2990c6a6e0245842();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c104fec8109b869a2990c6a6e0245842() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_dcebdd8ba305133f41b1e1804925997fEntityRecord> NewList() {
return new RL_c104fec8109b869a2990c6a6e0245842();
}


} // RL_c104fec8109b869a2990c6a6e0245842
}
