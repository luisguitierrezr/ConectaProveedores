using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] FolioObservations (eFXn7Zdkl0CW7YLV9hKsFg)
///  <code>EN_171b22187ea6e4b12c9f086502740307EntityRecord</code> that represent
/// s <code>FolioObservations</code> <p>Description: </p>
/// </summary>
// Name: FolioObservations
public partial struct EN_171b22187ea6e4b12c9f086502740307EntityRecord : ITypedRecord<EN_171b22187ea6e4b12c9f086502740307EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*M+Jco5elO023rmVNVmoPAg");
internal static readonly GlobalObjectKey IdFolioId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hw7G8xIuVkOJr06Csb1mbw");
internal static readonly GlobalObjectKey IdObservation = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*G0v2YpjJpki_5gdo1Argqg");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*o_7Rd1ohV0qwYY_lPuvWVw");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*aLyaiZbukkaRQYf2N2Rz8A");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(5,true);
          _ssId = value;
      }
  }
}

private long _ssFolioId;
public long ssFolioId{
  get{
      return _ssFolioId;
  }
  set{
      if((_ssFolioId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssFolioId = value;
      }
  }
}

private string _ssObservation;
public string ssObservation{
  get{
      return _ssObservation;
  }
  set{
      if((_ssObservation!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssObservation = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssCreatedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_171b22187ea6e4b12c9f086502740307EntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0L;
_ssFolioId = 0L;
_ssObservation = "";
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
ssId = r.ReadLongInteger(index++, "FolioObservations.Id", 0L);
ssFolioId = r.ReadEntityReferenceLongInteger(index++, "FolioObservations.FolioId", 0L);
ssObservation = r.ReadText(index++, "FolioObservations.Observation", "");
ssCreatedBy = r.ReadEntityReferenceText(index++, "FolioObservations.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "FolioObservations.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ChangedAttributes = new BitArray(5,false);
OptimizedAttributes = new BitArray(5,false);
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
public void ReadIM(EN_171b22187ea6e4b12c9f086502740307EntityRecord r) {
this = r;
}


public static bool operator == (EN_171b22187ea6e4b12c9f086502740307EntityRecord a, EN_171b22187ea6e4b12c9f086502740307EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssFolioId != b.ssFolioId) return false;
if (a.ssObservation != b.ssObservation) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
return true;
}

public static bool operator != (EN_171b22187ea6e4b12c9f086502740307EntityRecord a, EN_171b22187ea6e4b12c9f086502740307EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_171b22187ea6e4b12c9f086502740307EntityRecord)) return false;
return (this == (EN_171b22187ea6e4b12c9f086502740307EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssFolioId.GetHashCode()
 ^ ssObservation.GetHashCode()
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


public EN_171b22187ea6e4b12c9f086502740307EntityRecord Duplicate() {
EN_171b22187ea6e4b12c9f086502740307EntityRecord t;
t._ssId = this._ssId;
t._ssFolioId = this._ssFolioId;
t._ssObservation = this._ssObservation;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t.ChangedAttributes = new BitArray(5);
t.OptimizedAttributes = new BitArray(5);
for(int i = 0; i < 5; i++){
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
} else if (head == "folioid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioId")) variable.Value = ssFolioId; else variable.Optimized = true;
} else if (head == "observation") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Observation")) variable.Value = ssObservation; else variable.Optimized = true;
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
if (key.Equals(IdFolioId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdObservation)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdFolioId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdObservation)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdFolioId) {
return ssFolioId;
}
if (key == IdObservation) {
return ssObservation;
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
if (attributeKey == IdFolioId.Key.AsGuid) {
return ssFolioId;
}
if (attributeKey == IdObservation.Key.AsGuid) {
return ssObservation;
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
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssFolioId = (long) other.AttributeGet(IdFolioId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdFolioId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdFolioId);
ssObservation = (string) other.AttributeGet(IdObservation);
ChangedAttributes[2] = other.ChangedAttributeGet(IdObservation);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdObservation);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedOn);
}
} // EN_171b22187ea6e4b12c9f086502740307EntityRecord

/// <summary>
/// RecordList type <code>FolioObservationsList</code> that represents a record list of
///  <code>FolioObservations</code>
/// </summary>
public partial class RL_0042e117007664442af7bcd2a29f2870 : GenericRecordList<EN_171b22187ea6e4b12c9f086502740307EntityRecord>, IEnumerable, IEnumerator {

protected override EN_171b22187ea6e4b12c9f086502740307EntityRecord GetElementDefaultValue() {
return new EN_171b22187ea6e4b12c9f086502740307EntityRecord();
}

public T[] ToArray<T>(Func<EN_171b22187ea6e4b12c9f086502740307EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0042e117007664442af7bcd2a29f2870 recordList, Func<EN_171b22187ea6e4b12c9f086502740307EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0042e117007664442af7bcd2a29f2870(EN_171b22187ea6e4b12c9f086502740307EntityRecord[] array) {
  RL_0042e117007664442af7bcd2a29f2870 result = new RL_0042e117007664442af7bcd2a29f2870();
result.InnerFromArray(array);
    return result;
}

public static RL_0042e117007664442af7bcd2a29f2870 ToList<T>(T[] array, Func <T, EN_171b22187ea6e4b12c9f086502740307EntityRecord> converter) {
  RL_0042e117007664442af7bcd2a29f2870 result = new RL_0042e117007664442af7bcd2a29f2870();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0042e117007664442af7bcd2a29f2870 FromRestList<T>(RestList<T> restList, Func <T, EN_171b22187ea6e4b12c9f086502740307EntityRecord> converter) {
  RL_0042e117007664442af7bcd2a29f2870 result = new RL_0042e117007664442af7bcd2a29f2870();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0042e117007664442af7bcd2a29f2870() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_171b22187ea6e4b12c9f086502740307EntityRecord> NewList() {
return new RL_0042e117007664442af7bcd2a29f2870();
}


} // RL_0042e117007664442af7bcd2a29f2870
}
