using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] UserApplicationRoleTempByConcept (O50qIKOG0kGp6E3xWfR3Dw)
///  <code>EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord</code> that represent
/// s <code>UserApplicationRoleTempByConcept</code> <p>Description: Entity that holds user temporary
///  roles by concept</p>
/// </summary>
// Name: UserApplicationRoleTempByConcept
public partial struct EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord : ITypedRecord<EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*1Ahfd+8kjU6cT9eJTKuhgQ");
internal static readonly GlobalObjectKey IdUserApplicationRoleTempId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*8UCz2UmYUEmiLWfJ9W80lA");
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*tK3i48y5F0SYjAimyOfNzQ");
internal static readonly GlobalObjectKey IdConceptId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*ISiX5gDaB0CSuqCZxMnEew");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(4,true);
          _ssId = value;
      }
  }
}

private long _ssUserApplicationRoleTempId;
public long ssUserApplicationRoleTempId{
  get{
      return _ssUserApplicationRoleTempId;
  }
  set{
      if((_ssUserApplicationRoleTempId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssUserApplicationRoleTempId = value;
      }
  }
}

private long _ssApplicationRoleId;
public long ssApplicationRoleId{
  get{
      return _ssApplicationRoleId;
  }
  set{
      if((_ssApplicationRoleId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssApplicationRoleId = value;
      }
  }
}

private int _ssConceptId;
public int ssConceptId{
  get{
      return _ssConceptId;
  }
  set{
      if((_ssConceptId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssConceptId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord() {
ChangedAttributes = new BitArray(4,true);
OptimizedAttributes = new BitArray(4,false);
_ssId = 0L;
_ssUserApplicationRoleTempId = 0L;
_ssApplicationRoleId = 0L;
_ssConceptId = 0;
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
ssId = r.ReadLongInteger(index++, "UserApplicationRoleTempByConcept.Id", 0L);
ssUserApplicationRoleTempId = r.ReadEntityReferenceLongInteger(index++, "UserApplicationRoleTempByConcept.UserApplicationRoleTempId", 0L);
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "UserApplicationRoleTempByConcept.ApplicationRoleId", 0L);
ssConceptId = r.ReadEntityReference(index++, "UserApplicationRoleTempByConcept.ConceptId", 0);
ChangedAttributes = new BitArray(4,false);
OptimizedAttributes = new BitArray(4,false);
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
public void ReadIM(EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord r) {
this = r;
}


public static bool operator == (EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord a, EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssUserApplicationRoleTempId != b.ssUserApplicationRoleTempId) return false;
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssConceptId != b.ssConceptId) return false;
return true;
}

public static bool operator != (EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord a, EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord)) return false;
return (this == (EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssUserApplicationRoleTempId.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
 ^ ssConceptId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord Duplicate() {
EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord t;
t._ssId = this._ssId;
t._ssUserApplicationRoleTempId = this._ssUserApplicationRoleTempId;
t._ssApplicationRoleId = this._ssApplicationRoleId;
t._ssConceptId = this._ssConceptId;
t.ChangedAttributes = new BitArray(4);
t.OptimizedAttributes = new BitArray(4);
for(int i = 0; i < 4; i++){
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
} else if (head == "userapplicationroletempid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserApplicationRoleTempId")) variable.Value = ssUserApplicationRoleTempId; else variable.Optimized = true;
} else if (head == "applicationroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRoleId")) variable.Value = ssApplicationRoleId; else variable.Optimized = true;
} else if (head == "conceptid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ConceptId")) variable.Value = ssConceptId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdUserApplicationRoleTempId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdApplicationRoleId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdConceptId)) {
return ChangedAttributes[3];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdUserApplicationRoleTempId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdApplicationRoleId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdConceptId)) {
return OptimizedAttributes[3];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdUserApplicationRoleTempId) {
return ssUserApplicationRoleTempId;
}
if (key == IdApplicationRoleId) {
return ssApplicationRoleId;
}
if (key == IdConceptId) {
return ssConceptId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdUserApplicationRoleTempId.Key.AsGuid) {
return ssUserApplicationRoleTempId;
}
if (attributeKey == IdApplicationRoleId.Key.AsGuid) {
return ssApplicationRoleId;
}
if (attributeKey == IdConceptId.Key.AsGuid) {
return ssConceptId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(4);
OptimizedAttributes = new BitArray(4);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssUserApplicationRoleTempId = (long) other.AttributeGet(IdUserApplicationRoleTempId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdUserApplicationRoleTempId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdUserApplicationRoleTempId);
ssApplicationRoleId = (long) other.AttributeGet(IdApplicationRoleId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdApplicationRoleId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdApplicationRoleId);
ssConceptId = (int) other.AttributeGet(IdConceptId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdConceptId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdConceptId);
}
} // EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord

/// <summary>
/// RecordList type <code>UserApplicationRoleTempByConceptList</code> that represents a record list of
///  <code>UserApplicationRoleTempByConcept</code>
/// </summary>
public partial class RL_72a48a67da92d5df2d192a5d7b1f5247 : GenericRecordList<EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord>, IEnumerable, IEnumerator {

protected override EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord GetElementDefaultValue() {
return new EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord();
}

public T[] ToArray<T>(Func<EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_72a48a67da92d5df2d192a5d7b1f5247 recordList, Func<EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_72a48a67da92d5df2d192a5d7b1f5247(EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord[] array) {
  RL_72a48a67da92d5df2d192a5d7b1f5247 result = new RL_72a48a67da92d5df2d192a5d7b1f5247();
result.InnerFromArray(array);
    return result;
}

public static RL_72a48a67da92d5df2d192a5d7b1f5247 ToList<T>(T[] array, Func <T, EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord> converter) {
  RL_72a48a67da92d5df2d192a5d7b1f5247 result = new RL_72a48a67da92d5df2d192a5d7b1f5247();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_72a48a67da92d5df2d192a5d7b1f5247 FromRestList<T>(RestList<T> restList, Func <T, EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord> converter) {
  RL_72a48a67da92d5df2d192a5d7b1f5247 result = new RL_72a48a67da92d5df2d192a5d7b1f5247();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_72a48a67da92d5df2d192a5d7b1f5247() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord> NewList() {
return new RL_72a48a67da92d5df2d192a5d7b1f5247();
}


} // RL_72a48a67da92d5df2d192a5d7b1f5247
}
