namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (0HhLHRN6wECLLv2wvtv75Q)
///  <code>RC_66c67d926e518c0b673d9119f62da193</code> that represent
/// s <code>UserApplicationRoleTempRecord</code> <p>Description: </p>
/// </summary>
// Name: UserApplicationRoleTempRecord
public partial struct RC_66c67d926e518c0b673d9119f62da193 : ITypedRecord<RC_66c67d926e518c0b673d9119f62da193> {
internal static readonly GlobalObjectKey IdUserApplicationRoleTemp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kn3GZlFuC4xnPZEZ9i2hkw");

public EN_20bdea9cf8f17569719f414a83b584b6EntityRecord ssENUserApplicationRoleTemp;


public static implicit operator EN_20bdea9cf8f17569719f414a83b584b6EntityRecord( RC_66c67d926e518c0b673d9119f62da193 r) {
return r.ssENUserApplicationRoleTemp;
}

public static implicit operator RC_66c67d926e518c0b673d9119f62da193 (EN_20bdea9cf8f17569719f414a83b584b6EntityRecord r) {
RC_66c67d926e518c0b673d9119f62da193 res = new RC_66c67d926e518c0b673d9119f62da193 ();
res.ssENUserApplicationRoleTemp = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENUserApplicationRoleTemp.ChangedAttributes = value;
}
get {
    return ssENUserApplicationRoleTemp.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_66c67d926e518c0b673d9119f62da193() {
OptimizedAttributes = null;
ssENUserApplicationRoleTemp = new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(14,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUserApplicationRoleTemp.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENUserApplicationRoleTemp.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENUserApplicationRoleTemp.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUserApplicationRoleTemp.Read( r, ref index);
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
public void ReadIM(RC_66c67d926e518c0b673d9119f62da193 r) {
this = r;
}


public static bool operator == (RC_66c67d926e518c0b673d9119f62da193 a, RC_66c67d926e518c0b673d9119f62da193 b) {
if (a.ssENUserApplicationRoleTemp != b.ssENUserApplicationRoleTemp) return false;
return true;
}

public static bool operator != (RC_66c67d926e518c0b673d9119f62da193 a, RC_66c67d926e518c0b673d9119f62da193 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_66c67d926e518c0b673d9119f62da193)) return false;
return (this == (RC_66c67d926e518c0b673d9119f62da193)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUserApplicationRoleTemp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUserApplicationRoleTemp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUserApplicationRoleTemp.InternalRecursiveSave();
}


public RC_66c67d926e518c0b673d9119f62da193 Duplicate() {
RC_66c67d926e518c0b673d9119f62da193 t;
t.ssENUserApplicationRoleTemp = (EN_20bdea9cf8f17569719f414a83b584b6EntityRecord)this.ssENUserApplicationRoleTemp.Duplicate();
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
if (head == "userapplicationroletemp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserApplicationRoleTemp")) variable.Value = ssENUserApplicationRoleTemp; else variable.Optimized = true;
variable.SetFieldName("userapplicationroletemp");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENUserApplicationRoleTemp.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENUserApplicationRoleTemp.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdUserApplicationRoleTemp) {
return ssENUserApplicationRoleTemp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserApplicationRoleTemp.Key.AsGuid) {
return ssENUserApplicationRoleTemp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUserApplicationRoleTemp.FillFromOther((IRecord) other.AttributeGet(IdUserApplicationRoleTemp));
}
} // RC_66c67d926e518c0b673d9119f62da193
/// <summary>
/// RecordList type <code>UserApplicationRoleTempRecordList</code> that represents a record list of
///  <code>UserApplicationRoleTemp</code>
/// </summary>
public partial class RL_87311ea350338b4dcd53388d23fa3f86 : GenericRecordList<RC_66c67d926e518c0b673d9119f62da193>, IEnumerable, IEnumerator {

protected override RC_66c67d926e518c0b673d9119f62da193 GetElementDefaultValue() {
return new RC_66c67d926e518c0b673d9119f62da193();
}

public T[] ToArray<T>(Func<RC_66c67d926e518c0b673d9119f62da193, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_87311ea350338b4dcd53388d23fa3f86 recordList, Func<RC_66c67d926e518c0b673d9119f62da193, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_87311ea350338b4dcd53388d23fa3f86(RC_66c67d926e518c0b673d9119f62da193[] array) {
  RL_87311ea350338b4dcd53388d23fa3f86 result = new RL_87311ea350338b4dcd53388d23fa3f86();
result.InnerFromArray(array);
    return result;
}

public static RL_87311ea350338b4dcd53388d23fa3f86 ToList<T>(T[] array, Func <T, RC_66c67d926e518c0b673d9119f62da193> converter) {
  RL_87311ea350338b4dcd53388d23fa3f86 result = new RL_87311ea350338b4dcd53388d23fa3f86();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_87311ea350338b4dcd53388d23fa3f86 FromRestList<T>(RestList<T> restList, Func <T, RC_66c67d926e518c0b673d9119f62da193> converter) {
  RL_87311ea350338b4dcd53388d23fa3f86 result = new RL_87311ea350338b4dcd53388d23fa3f86();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_87311ea350338b4dcd53388d23fa3f86() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(14,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_66c67d926e518c0b673d9119f62da193> NewList() {
return new RL_87311ea350338b4dcd53388d23fa3f86();
}


} // RL_87311ea350338b4dcd53388d23fa3f86
}

