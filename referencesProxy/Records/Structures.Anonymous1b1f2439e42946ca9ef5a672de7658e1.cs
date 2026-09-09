namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (OSQfGynkykae9aZy3nZY4Q)
///  <code>RC_5f28219a5e30fb90023fcbc295513e7c</code> that represents <code>PositionRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PositionRecord
public partial struct RC_5f28219a5e30fb90023fcbc295513e7c : ITypedRecord<RC_5f28219a5e30fb90023fcbc295513e7c> {
internal static readonly GlobalObjectKey IdPosition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*miEoXzBekPsCP8vClVE+fA");

public EN_5d1279724e719322292e34ef3c5500a0EntityRecord ssENPosition;


public static implicit operator EN_5d1279724e719322292e34ef3c5500a0EntityRecord( RC_5f28219a5e30fb90023fcbc295513e7c r) {
return r.ssENPosition;
}

public static implicit operator RC_5f28219a5e30fb90023fcbc295513e7c (EN_5d1279724e719322292e34ef3c5500a0EntityRecord r) {
RC_5f28219a5e30fb90023fcbc295513e7c res = new RC_5f28219a5e30fb90023fcbc295513e7c ();
res.ssENPosition = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENPosition.ChangedAttributes = value;
}
get {
    return ssENPosition.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_5f28219a5e30fb90023fcbc295513e7c() {
OptimizedAttributes = null;
ssENPosition = new EN_5d1279724e719322292e34ef3c5500a0EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENPosition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENPosition.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENPosition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENPosition.Read( r, ref index);
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
public void ReadIM(RC_5f28219a5e30fb90023fcbc295513e7c r) {
this = r;
}


public static bool operator == (RC_5f28219a5e30fb90023fcbc295513e7c a, RC_5f28219a5e30fb90023fcbc295513e7c b) {
if (a.ssENPosition != b.ssENPosition) return false;
return true;
}

public static bool operator != (RC_5f28219a5e30fb90023fcbc295513e7c a, RC_5f28219a5e30fb90023fcbc295513e7c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5f28219a5e30fb90023fcbc295513e7c)) return false;
return (this == (RC_5f28219a5e30fb90023fcbc295513e7c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENPosition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENPosition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENPosition.InternalRecursiveSave();
}


public RC_5f28219a5e30fb90023fcbc295513e7c Duplicate() {
RC_5f28219a5e30fb90023fcbc295513e7c t;
t.ssENPosition = (EN_5d1279724e719322292e34ef3c5500a0EntityRecord)this.ssENPosition.Duplicate();
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
if (head == "position") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Position")) variable.Value = ssENPosition; else variable.Optimized = true;
variable.SetFieldName("position");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENPosition.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENPosition.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdPosition) {
return ssENPosition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPosition.Key.AsGuid) {
return ssENPosition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENPosition.FillFromOther((IRecord) other.AttributeGet(IdPosition));
}
} // RC_5f28219a5e30fb90023fcbc295513e7c
/// <summary>
/// RecordList type <code>PositionRecordList</code> that represents a record list of
///  <code>Position</code>
/// </summary>
public partial class RL_5ba41fd2555db2daaba8da89df34a9b8 : GenericRecordList<RC_5f28219a5e30fb90023fcbc295513e7c>, IEnumerable, IEnumerator {

protected override RC_5f28219a5e30fb90023fcbc295513e7c GetElementDefaultValue() {
return new RC_5f28219a5e30fb90023fcbc295513e7c();
}

public T[] ToArray<T>(Func<RC_5f28219a5e30fb90023fcbc295513e7c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5ba41fd2555db2daaba8da89df34a9b8 recordList, Func<RC_5f28219a5e30fb90023fcbc295513e7c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5ba41fd2555db2daaba8da89df34a9b8(RC_5f28219a5e30fb90023fcbc295513e7c[] array) {
  RL_5ba41fd2555db2daaba8da89df34a9b8 result = new RL_5ba41fd2555db2daaba8da89df34a9b8();
result.InnerFromArray(array);
    return result;
}

public static RL_5ba41fd2555db2daaba8da89df34a9b8 ToList<T>(T[] array, Func <T, RC_5f28219a5e30fb90023fcbc295513e7c> converter) {
  RL_5ba41fd2555db2daaba8da89df34a9b8 result = new RL_5ba41fd2555db2daaba8da89df34a9b8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5ba41fd2555db2daaba8da89df34a9b8 FromRestList<T>(RestList<T> restList, Func <T, RC_5f28219a5e30fb90023fcbc295513e7c> converter) {
  RL_5ba41fd2555db2daaba8da89df34a9b8 result = new RL_5ba41fd2555db2daaba8da89df34a9b8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5ba41fd2555db2daaba8da89df34a9b8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5f28219a5e30fb90023fcbc295513e7c> NewList() {
return new RL_5ba41fd2555db2daaba8da89df34a9b8();
}


} // RL_5ba41fd2555db2daaba8da89df34a9b8
}

