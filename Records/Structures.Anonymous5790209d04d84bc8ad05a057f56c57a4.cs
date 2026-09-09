namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (nSCQV9gEyEutBaBX9WxXpA)
///  <code>RC_c4cc207f9017de4e013fabcf1e8ebeaf</code> that represents <code>OrderMainItemRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderMainItemRecord
public partial struct RC_c4cc207f9017de4e013fabcf1e8ebeaf : ITypedRecord<RC_c4cc207f9017de4e013fabcf1e8ebeaf> {
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;


public static implicit operator EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord( RC_c4cc207f9017de4e013fabcf1e8ebeaf r) {
return r.ssENOrderMainItem;
}

public static implicit operator RC_c4cc207f9017de4e013fabcf1e8ebeaf (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord r) {
RC_c4cc207f9017de4e013fabcf1e8ebeaf res = new RC_c4cc207f9017de4e013fabcf1e8ebeaf ();
res.ssENOrderMainItem = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderMainItem.ChangedAttributes = value;
}
get {
    return ssENOrderMainItem.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_c4cc207f9017de4e013fabcf1e8ebeaf() {
OptimizedAttributes = null;
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(51,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderMainItem.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderMainItem.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderMainItem.Read( r, ref index);
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
public void ReadIM(RC_c4cc207f9017de4e013fabcf1e8ebeaf r) {
this = r;
}


public static bool operator == (RC_c4cc207f9017de4e013fabcf1e8ebeaf a, RC_c4cc207f9017de4e013fabcf1e8ebeaf b) {
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
return true;
}

public static bool operator != (RC_c4cc207f9017de4e013fabcf1e8ebeaf a, RC_c4cc207f9017de4e013fabcf1e8ebeaf b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c4cc207f9017de4e013fabcf1e8ebeaf)) return false;
return (this == (RC_c4cc207f9017de4e013fabcf1e8ebeaf)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMainItem.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMainItem.InternalRecursiveSave();
}


public RC_c4cc207f9017de4e013fabcf1e8ebeaf Duplicate() {
RC_c4cc207f9017de4e013fabcf1e8ebeaf t;
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
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
if (head == "ordermainitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItem")) variable.Value = ssENOrderMainItem; else variable.Optimized = true;
variable.SetFieldName("ordermainitem");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderMainItem.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderMainItem.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderMainItem) {
return ssENOrderMainItem;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMainItem.Key.AsGuid) {
return ssENOrderMainItem;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
}
} // RC_c4cc207f9017de4e013fabcf1e8ebeaf
/// <summary>
/// RecordList type <code>OrderMainItemRecordList</code> that represents a record list of
///  <code>OrderMainItem</code>
/// </summary>
public partial class RL_361bfb1983e170050cb9d371d001b386 : GenericRecordList<RC_c4cc207f9017de4e013fabcf1e8ebeaf>, IEnumerable, IEnumerator {

protected override RC_c4cc207f9017de4e013fabcf1e8ebeaf GetElementDefaultValue() {
return new RC_c4cc207f9017de4e013fabcf1e8ebeaf();
}

public T[] ToArray<T>(Func<RC_c4cc207f9017de4e013fabcf1e8ebeaf, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_361bfb1983e170050cb9d371d001b386 recordList, Func<RC_c4cc207f9017de4e013fabcf1e8ebeaf, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_361bfb1983e170050cb9d371d001b386(RC_c4cc207f9017de4e013fabcf1e8ebeaf[] array) {
  RL_361bfb1983e170050cb9d371d001b386 result = new RL_361bfb1983e170050cb9d371d001b386();
result.InnerFromArray(array);
    return result;
}

public static RL_361bfb1983e170050cb9d371d001b386 ToList<T>(T[] array, Func <T, RC_c4cc207f9017de4e013fabcf1e8ebeaf> converter) {
  RL_361bfb1983e170050cb9d371d001b386 result = new RL_361bfb1983e170050cb9d371d001b386();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_361bfb1983e170050cb9d371d001b386 FromRestList<T>(RestList<T> restList, Func <T, RC_c4cc207f9017de4e013fabcf1e8ebeaf> converter) {
  RL_361bfb1983e170050cb9d371d001b386 result = new RL_361bfb1983e170050cb9d371d001b386();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_361bfb1983e170050cb9d371d001b386() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(51,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c4cc207f9017de4e013fabcf1e8ebeaf> NewList() {
return new RL_361bfb1983e170050cb9d371d001b386();
}


} // RL_361bfb1983e170050cb9d371d001b386
}

