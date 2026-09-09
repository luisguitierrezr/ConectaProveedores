using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] RoleConcept (73pLfMUAFkG0ul8xHG2V9g)
///  <code>EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord</code> that represent
/// s <code>RoleConcept</code> <p>Description: Role Concept</p>
/// </summary>
// Name: RoleConcept
public partial struct EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord : ITypedRecord<EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*3phgjbNmwUmKCXKoV+2UVg");
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*EmOiH6hMbUyfofkE6AKvTg");
internal static readonly GlobalObjectKey IdConceptId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*MaDX_NAJd0eGwBEKsyErIg");
internal static readonly GlobalObjectKey IdEntraRoleId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*FmI6VewrJkyrX46P8OVFBw");

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

private long _ssApplicationRoleId;
public long ssApplicationRoleId{
  get{
      return _ssApplicationRoleId;
  }
  set{
      if((_ssApplicationRoleId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
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
      if((_ssConceptId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssConceptId = value;
      }
  }
}

private long _ssEntraRoleId;
public long ssEntraRoleId{
  get{
      return _ssEntraRoleId;
  }
  set{
      if((_ssEntraRoleId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssEntraRoleId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord() {
ChangedAttributes = new BitArray(4,true);
OptimizedAttributes = new BitArray(4,false);
_ssId = 0L;
_ssApplicationRoleId = 0L;
_ssConceptId = 0;
_ssEntraRoleId = 0L;
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
ssId = r.ReadLongInteger(index++, "RoleConcept.Id", 0L);
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "RoleConcept.ApplicationRoleId", 0L);
ssConceptId = r.ReadEntityReference(index++, "RoleConcept.ConceptId", 0);
ssEntraRoleId = r.ReadEntityReferenceLongInteger(index++, "RoleConcept.EntraRoleId", 0L);
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
public void ReadIM(EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord r) {
this = r;
}


public static bool operator == (EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord a, EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssConceptId != b.ssConceptId) return false;
if (a.ssEntraRoleId != b.ssEntraRoleId) return false;
return true;
}

public static bool operator != (EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord a, EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord)) return false;
return (this == (EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
 ^ ssConceptId.GetHashCode()
 ^ ssEntraRoleId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord Duplicate() {
EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord t;
t._ssId = this._ssId;
t._ssApplicationRoleId = this._ssApplicationRoleId;
t._ssConceptId = this._ssConceptId;
t._ssEntraRoleId = this._ssEntraRoleId;
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
} else if (head == "applicationroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRoleId")) variable.Value = ssApplicationRoleId; else variable.Optimized = true;
} else if (head == "conceptid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ConceptId")) variable.Value = ssConceptId; else variable.Optimized = true;
} else if (head == "entraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRoleId")) variable.Value = ssEntraRoleId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdApplicationRoleId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdConceptId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdEntraRoleId)) {
return ChangedAttributes[3];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdApplicationRoleId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdConceptId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdEntraRoleId)) {
return OptimizedAttributes[3];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdApplicationRoleId) {
return ssApplicationRoleId;
}
if (key == IdConceptId) {
return ssConceptId;
}
if (key == IdEntraRoleId) {
return ssEntraRoleId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdApplicationRoleId.Key.AsGuid) {
return ssApplicationRoleId;
}
if (attributeKey == IdConceptId.Key.AsGuid) {
return ssConceptId;
}
if (attributeKey == IdEntraRoleId.Key.AsGuid) {
return ssEntraRoleId;
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
ssApplicationRoleId = (long) other.AttributeGet(IdApplicationRoleId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdApplicationRoleId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdApplicationRoleId);
ssConceptId = (int) other.AttributeGet(IdConceptId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdConceptId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdConceptId);
ssEntraRoleId = (long) other.AttributeGet(IdEntraRoleId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdEntraRoleId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdEntraRoleId);
}
} // EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord

/// <summary>
/// RecordList type <code>RoleConceptList</code> that represents a record list of
///  <code>RoleConcept</code>
/// </summary>
public partial class RL_6efb452c96104d5237e28f1e59110826 : GenericRecordList<EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord>, IEnumerable, IEnumerator {

protected override EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord GetElementDefaultValue() {
return new EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord();
}

public T[] ToArray<T>(Func<EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6efb452c96104d5237e28f1e59110826 recordList, Func<EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6efb452c96104d5237e28f1e59110826(EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord[] array) {
  RL_6efb452c96104d5237e28f1e59110826 result = new RL_6efb452c96104d5237e28f1e59110826();
result.InnerFromArray(array);
    return result;
}

public static RL_6efb452c96104d5237e28f1e59110826 ToList<T>(T[] array, Func <T, EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord> converter) {
  RL_6efb452c96104d5237e28f1e59110826 result = new RL_6efb452c96104d5237e28f1e59110826();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6efb452c96104d5237e28f1e59110826 FromRestList<T>(RestList<T> restList, Func <T, EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord> converter) {
  RL_6efb452c96104d5237e28f1e59110826 result = new RL_6efb452c96104d5237e28f1e59110826();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6efb452c96104d5237e28f1e59110826() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord> NewList() {
return new RL_6efb452c96104d5237e28f1e59110826();
}


} // RL_6efb452c96104d5237e28f1e59110826
}
