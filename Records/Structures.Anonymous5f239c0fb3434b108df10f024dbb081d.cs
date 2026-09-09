namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (D5wjX0OzEEuN8Q8CTbsIHQ)
///  <code>RC_24005b43e3f3ca8801049bcbbd68ea10</code> that represent
/// s <code>SymbolTotalValueMLSumRecord</code> <p>Description: </p>
/// </summary>
// Name: SymbolTotalValueMLSumRecord
public partial struct RC_24005b43e3f3ca8801049bcbbd68ea10 : ITypedRecord<RC_24005b43e3f3ca8801049bcbbd68ea10> {
internal static readonly GlobalObjectKey IdSymbol = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*amah9FlvmQCJGwIiB0uD9Q");
internal static readonly GlobalObjectKey IdTotalValueMLSum = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ozk6thDGGdsnTHlfIzrQGg");

public string ssSymbol;

public decimal ssTotalValueMLSum;


public BitArray OptimizedAttributes;

public RC_24005b43e3f3ca8801049bcbbd68ea10() {
OptimizedAttributes = null;
ssSymbol = "";
ssTotalValueMLSum = 0.0M;
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
ssSymbol = r.ReadText(index++, "SymbolTotalValueMLSumRecord.Symbol", "");
ssTotalValueMLSum = r.ReadDecimal(index++, "SymbolTotalValueMLSumRecord.TotalValueMLSum", 0.0M);
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
public void ReadIM(RC_24005b43e3f3ca8801049bcbbd68ea10 r) {
this = r;
}


public static bool operator == (RC_24005b43e3f3ca8801049bcbbd68ea10 a, RC_24005b43e3f3ca8801049bcbbd68ea10 b) {
if (a.ssSymbol != b.ssSymbol) return false;
if (a.ssTotalValueMLSum != b.ssTotalValueMLSum) return false;
return true;
}

public static bool operator != (RC_24005b43e3f3ca8801049bcbbd68ea10 a, RC_24005b43e3f3ca8801049bcbbd68ea10 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_24005b43e3f3ca8801049bcbbd68ea10)) return false;
return (this == (RC_24005b43e3f3ca8801049bcbbd68ea10)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSymbol.GetHashCode()
 ^ ssTotalValueMLSum.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_24005b43e3f3ca8801049bcbbd68ea10 Duplicate() {
RC_24005b43e3f3ca8801049bcbbd68ea10 t;
t.ssSymbol = this.ssSymbol;
t.ssTotalValueMLSum = this.ssTotalValueMLSum;
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
if (head == "symbol") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Symbol")) variable.Value = ssSymbol; else variable.Optimized = true;
} else if (head == "totalvaluemlsum") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalValueMLSum")) variable.Value = ssTotalValueMLSum; else variable.Optimized = true;
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
if (key == IdSymbol) {
return ssSymbol;
}
if (key == IdTotalValueMLSum) {
return ssTotalValueMLSum;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSymbol.Key.AsGuid) {
return ssSymbol;
}
if (attributeKey == IdTotalValueMLSum.Key.AsGuid) {
return ssTotalValueMLSum;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSymbol = (string) other.AttributeGet(IdSymbol);
ssTotalValueMLSum = (decimal) other.AttributeGet(IdTotalValueMLSum);
}
} // RC_24005b43e3f3ca8801049bcbbd68ea10
/// <summary>
/// RecordList type <code>SymbolTotalValueMLSumRecordList</code> that represents a record list of
///  <code>Text, Decimal</code>
/// </summary>
public partial class RL_c43fa070956fae30a46b9d776792d6cc : GenericRecordList<RC_24005b43e3f3ca8801049bcbbd68ea10>, IEnumerable, IEnumerator {

protected override RC_24005b43e3f3ca8801049bcbbd68ea10 GetElementDefaultValue() {
return new RC_24005b43e3f3ca8801049bcbbd68ea10();
}

public T[] ToArray<T>(Func<RC_24005b43e3f3ca8801049bcbbd68ea10, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c43fa070956fae30a46b9d776792d6cc recordList, Func<RC_24005b43e3f3ca8801049bcbbd68ea10, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c43fa070956fae30a46b9d776792d6cc(RC_24005b43e3f3ca8801049bcbbd68ea10[] array) {
  RL_c43fa070956fae30a46b9d776792d6cc result = new RL_c43fa070956fae30a46b9d776792d6cc();
result.InnerFromArray(array);
    return result;
}

public static RL_c43fa070956fae30a46b9d776792d6cc ToList<T>(T[] array, Func <T, RC_24005b43e3f3ca8801049bcbbd68ea10> converter) {
  RL_c43fa070956fae30a46b9d776792d6cc result = new RL_c43fa070956fae30a46b9d776792d6cc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c43fa070956fae30a46b9d776792d6cc FromRestList<T>(RestList<T> restList, Func <T, RC_24005b43e3f3ca8801049bcbbd68ea10> converter) {
  RL_c43fa070956fae30a46b9d776792d6cc result = new RL_c43fa070956fae30a46b9d776792d6cc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c43fa070956fae30a46b9d776792d6cc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_24005b43e3f3ca8801049bcbbd68ea10> NewList() {
return new RL_c43fa070956fae30a46b9d776792d6cc();
}


} // RL_c43fa070956fae30a46b9d776792d6cc
}

