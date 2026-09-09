namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (+VDAymgr20eZy9BSg4t0pQ)
///  <code>RC_4efb69cb4fc55f904087bd266147c4db</code> that represents <code>TotalSumRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TotalSumRecord
public partial struct RC_4efb69cb4fc55f904087bd266147c4db : ITypedRecord<RC_4efb69cb4fc55f904087bd266147c4db> {
internal static readonly GlobalObjectKey IdTotalSum = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*y2n7TsVPkF9Ah70mYUfE2w");

public decimal ssTotalSum;


public BitArray OptimizedAttributes;

public RC_4efb69cb4fc55f904087bd266147c4db() {
OptimizedAttributes = null;
ssTotalSum = 0.0M;
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
ssTotalSum = r.ReadDecimal(index++, "TotalSumRecord.TotalSum", 0.0M);
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
public void ReadIM(RC_4efb69cb4fc55f904087bd266147c4db r) {
this = r;
}


public static bool operator == (RC_4efb69cb4fc55f904087bd266147c4db a, RC_4efb69cb4fc55f904087bd266147c4db b) {
if (a.ssTotalSum != b.ssTotalSum) return false;
return true;
}

public static bool operator != (RC_4efb69cb4fc55f904087bd266147c4db a, RC_4efb69cb4fc55f904087bd266147c4db b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4efb69cb4fc55f904087bd266147c4db)) return false;
return (this == (RC_4efb69cb4fc55f904087bd266147c4db)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssTotalSum.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_4efb69cb4fc55f904087bd266147c4db Duplicate() {
RC_4efb69cb4fc55f904087bd266147c4db t;
t.ssTotalSum = this.ssTotalSum;
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
if (head == "totalsum") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalSum")) variable.Value = ssTotalSum; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdTotalSum) {
return ssTotalSum;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTotalSum.Key.AsGuid) {
return ssTotalSum;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssTotalSum = (decimal) other.AttributeGet(IdTotalSum);
}
} // RC_4efb69cb4fc55f904087bd266147c4db
/// <summary>
/// RecordList type <code>TotalSumRecordList</code> that represents a record list of
///  <code>Decimal</code>
/// </summary>
public partial class RL_ecf075efbdf79b05fa564fa6ba80a9c6 : GenericRecordList<RC_4efb69cb4fc55f904087bd266147c4db>, IEnumerable, IEnumerator {

protected override RC_4efb69cb4fc55f904087bd266147c4db GetElementDefaultValue() {
return new RC_4efb69cb4fc55f904087bd266147c4db();
}

public T[] ToArray<T>(Func<RC_4efb69cb4fc55f904087bd266147c4db, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ecf075efbdf79b05fa564fa6ba80a9c6 recordList, Func<RC_4efb69cb4fc55f904087bd266147c4db, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ecf075efbdf79b05fa564fa6ba80a9c6(RC_4efb69cb4fc55f904087bd266147c4db[] array) {
  RL_ecf075efbdf79b05fa564fa6ba80a9c6 result = new RL_ecf075efbdf79b05fa564fa6ba80a9c6();
result.InnerFromArray(array);
    return result;
}

public static RL_ecf075efbdf79b05fa564fa6ba80a9c6 ToList<T>(T[] array, Func <T, RC_4efb69cb4fc55f904087bd266147c4db> converter) {
  RL_ecf075efbdf79b05fa564fa6ba80a9c6 result = new RL_ecf075efbdf79b05fa564fa6ba80a9c6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ecf075efbdf79b05fa564fa6ba80a9c6 FromRestList<T>(RestList<T> restList, Func <T, RC_4efb69cb4fc55f904087bd266147c4db> converter) {
  RL_ecf075efbdf79b05fa564fa6ba80a9c6 result = new RL_ecf075efbdf79b05fa564fa6ba80a9c6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ecf075efbdf79b05fa564fa6ba80a9c6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_4efb69cb4fc55f904087bd266147c4db> NewList() {
return new RL_ecf075efbdf79b05fa564fa6ba80a9c6();
}


} // RL_ecf075efbdf79b05fa564fa6ba80a9c6
}

