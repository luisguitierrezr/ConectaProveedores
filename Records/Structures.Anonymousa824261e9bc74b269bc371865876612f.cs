namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (HiYkqMebJkubw3GGWHZhLw)
///  <code>RC_054139ee1b4e118a0de0bda9edde9b3e</code> that represents <code>LegendPositionRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: LegendPositionRecord
public partial struct RC_054139ee1b4e118a0de0bda9edde9b3e : ITypedRecord<RC_054139ee1b4e118a0de0bda9edde9b3e> {
internal static readonly GlobalObjectKey IdLegendPosition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7jlBBU4bihEN4L2p7d6bPg");

public EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord ssENLegendPosition;


public static implicit operator EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord( RC_054139ee1b4e118a0de0bda9edde9b3e r) {
return r.ssENLegendPosition;
}

public static implicit operator RC_054139ee1b4e118a0de0bda9edde9b3e (EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord r) {
RC_054139ee1b4e118a0de0bda9edde9b3e res = new RC_054139ee1b4e118a0de0bda9edde9b3e ();
res.ssENLegendPosition = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENLegendPosition.ChangedAttributes = value;
}
get {
    return ssENLegendPosition.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_054139ee1b4e118a0de0bda9edde9b3e() {
OptimizedAttributes = null;
ssENLegendPosition = new EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENLegendPosition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENLegendPosition.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENLegendPosition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENLegendPosition.Read( r, ref index);
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
public void ReadIM(RC_054139ee1b4e118a0de0bda9edde9b3e r) {
this = r;
}


public static bool operator == (RC_054139ee1b4e118a0de0bda9edde9b3e a, RC_054139ee1b4e118a0de0bda9edde9b3e b) {
if (a.ssENLegendPosition != b.ssENLegendPosition) return false;
return true;
}

public static bool operator != (RC_054139ee1b4e118a0de0bda9edde9b3e a, RC_054139ee1b4e118a0de0bda9edde9b3e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_054139ee1b4e118a0de0bda9edde9b3e)) return false;
return (this == (RC_054139ee1b4e118a0de0bda9edde9b3e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENLegendPosition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENLegendPosition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENLegendPosition.InternalRecursiveSave();
}


public RC_054139ee1b4e118a0de0bda9edde9b3e Duplicate() {
RC_054139ee1b4e118a0de0bda9edde9b3e t;
t.ssENLegendPosition = (EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord)this.ssENLegendPosition.Duplicate();
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
if (head == "legendposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LegendPosition")) variable.Value = ssENLegendPosition; else variable.Optimized = true;
variable.SetFieldName("legendposition");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENLegendPosition.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENLegendPosition.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdLegendPosition) {
return ssENLegendPosition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLegendPosition.Key.AsGuid) {
return ssENLegendPosition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENLegendPosition.FillFromOther((IRecord) other.AttributeGet(IdLegendPosition));
}
} // RC_054139ee1b4e118a0de0bda9edde9b3e
/// <summary>
/// RecordList type <code>LegendPositionRecordList</code> that represents a record list of
///  <code>LegendPosition</code>
/// </summary>
public partial class RL_c5c0654c1652bc3a4b3d6451c97793d1 : GenericRecordList<RC_054139ee1b4e118a0de0bda9edde9b3e>, IEnumerable, IEnumerator {

protected override RC_054139ee1b4e118a0de0bda9edde9b3e GetElementDefaultValue() {
return new RC_054139ee1b4e118a0de0bda9edde9b3e();
}

public T[] ToArray<T>(Func<RC_054139ee1b4e118a0de0bda9edde9b3e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c5c0654c1652bc3a4b3d6451c97793d1 recordList, Func<RC_054139ee1b4e118a0de0bda9edde9b3e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c5c0654c1652bc3a4b3d6451c97793d1(RC_054139ee1b4e118a0de0bda9edde9b3e[] array) {
  RL_c5c0654c1652bc3a4b3d6451c97793d1 result = new RL_c5c0654c1652bc3a4b3d6451c97793d1();
result.InnerFromArray(array);
    return result;
}

public static RL_c5c0654c1652bc3a4b3d6451c97793d1 ToList<T>(T[] array, Func <T, RC_054139ee1b4e118a0de0bda9edde9b3e> converter) {
  RL_c5c0654c1652bc3a4b3d6451c97793d1 result = new RL_c5c0654c1652bc3a4b3d6451c97793d1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c5c0654c1652bc3a4b3d6451c97793d1 FromRestList<T>(RestList<T> restList, Func <T, RC_054139ee1b4e118a0de0bda9edde9b3e> converter) {
  RL_c5c0654c1652bc3a4b3d6451c97793d1 result = new RL_c5c0654c1652bc3a4b3d6451c97793d1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c5c0654c1652bc3a4b3d6451c97793d1() : base() {
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
protected override OSList<RC_054139ee1b4e118a0de0bda9edde9b3e> NewList() {
return new RL_c5c0654c1652bc3a4b3d6451c97793d1();
}


} // RL_c5c0654c1652bc3a4b3d6451c97793d1
}

