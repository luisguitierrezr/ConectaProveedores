namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Jt1NKr7YEUmR0IFCJke9BA)
///  <code>RC_5529030b7e85f68f6007e4d32f650ef7</code> that represent
/// s <code>AccountableGuideRecord</code> <p>Description: </p>
/// </summary>
// Name: AccountableGuideRecord
public partial struct RC_5529030b7e85f68f6007e4d32f650ef7 : ITypedRecord<RC_5529030b7e85f68f6007e4d32f650ef7> {
internal static readonly GlobalObjectKey IdAccountableGuide = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CwMpVYV+j_ZgB+TTL2UO9w");

public EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord ssENAccountableGuide;


public static implicit operator EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord( RC_5529030b7e85f68f6007e4d32f650ef7 r) {
return r.ssENAccountableGuide;
}

public static implicit operator RC_5529030b7e85f68f6007e4d32f650ef7 (EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord r) {
RC_5529030b7e85f68f6007e4d32f650ef7 res = new RC_5529030b7e85f68f6007e4d32f650ef7 ();
res.ssENAccountableGuide = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENAccountableGuide.ChangedAttributes = value;
}
get {
    return ssENAccountableGuide.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_5529030b7e85f68f6007e4d32f650ef7() {
OptimizedAttributes = null;
ssENAccountableGuide = new EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(11,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENAccountableGuide.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENAccountableGuide.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENAccountableGuide.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENAccountableGuide.Read( r, ref index);
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
public void ReadIM(RC_5529030b7e85f68f6007e4d32f650ef7 r) {
this = r;
}


public static bool operator == (RC_5529030b7e85f68f6007e4d32f650ef7 a, RC_5529030b7e85f68f6007e4d32f650ef7 b) {
if (a.ssENAccountableGuide != b.ssENAccountableGuide) return false;
return true;
}

public static bool operator != (RC_5529030b7e85f68f6007e4d32f650ef7 a, RC_5529030b7e85f68f6007e4d32f650ef7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5529030b7e85f68f6007e4d32f650ef7)) return false;
return (this == (RC_5529030b7e85f68f6007e4d32f650ef7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENAccountableGuide.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENAccountableGuide.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENAccountableGuide.InternalRecursiveSave();
}


public RC_5529030b7e85f68f6007e4d32f650ef7 Duplicate() {
RC_5529030b7e85f68f6007e4d32f650ef7 t;
t.ssENAccountableGuide = (EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord)this.ssENAccountableGuide.Duplicate();
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
if (head == "accountableguide") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountableGuide")) variable.Value = ssENAccountableGuide; else variable.Optimized = true;
variable.SetFieldName("accountableguide");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENAccountableGuide.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENAccountableGuide.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAccountableGuide) {
return ssENAccountableGuide;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAccountableGuide.Key.AsGuid) {
return ssENAccountableGuide;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENAccountableGuide.FillFromOther((IRecord) other.AttributeGet(IdAccountableGuide));
}
} // RC_5529030b7e85f68f6007e4d32f650ef7
/// <summary>
/// RecordList type <code>AccountableGuideRecordList</code> that represents a record list of
///  <code>AccountableGuide</code>
/// </summary>
public partial class RL_369f9983c2b36180025202f97bb71651 : GenericRecordList<RC_5529030b7e85f68f6007e4d32f650ef7>, IEnumerable, IEnumerator {

protected override RC_5529030b7e85f68f6007e4d32f650ef7 GetElementDefaultValue() {
return new RC_5529030b7e85f68f6007e4d32f650ef7();
}

public T[] ToArray<T>(Func<RC_5529030b7e85f68f6007e4d32f650ef7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_369f9983c2b36180025202f97bb71651 recordList, Func<RC_5529030b7e85f68f6007e4d32f650ef7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_369f9983c2b36180025202f97bb71651(RC_5529030b7e85f68f6007e4d32f650ef7[] array) {
  RL_369f9983c2b36180025202f97bb71651 result = new RL_369f9983c2b36180025202f97bb71651();
result.InnerFromArray(array);
    return result;
}

public static RL_369f9983c2b36180025202f97bb71651 ToList<T>(T[] array, Func <T, RC_5529030b7e85f68f6007e4d32f650ef7> converter) {
  RL_369f9983c2b36180025202f97bb71651 result = new RL_369f9983c2b36180025202f97bb71651();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_369f9983c2b36180025202f97bb71651 FromRestList<T>(RestList<T> restList, Func <T, RC_5529030b7e85f68f6007e4d32f650ef7> converter) {
  RL_369f9983c2b36180025202f97bb71651 result = new RL_369f9983c2b36180025202f97bb71651();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_369f9983c2b36180025202f97bb71651() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(11,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5529030b7e85f68f6007e4d32f650ef7> NewList() {
return new RL_369f9983c2b36180025202f97bb71651();
}


} // RL_369f9983c2b36180025202f97bb71651
}

