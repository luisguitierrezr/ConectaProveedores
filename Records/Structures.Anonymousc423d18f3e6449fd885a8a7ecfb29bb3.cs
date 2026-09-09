namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (j9EjxGQ+_UmIWop+z7Kbsw)
///  <code>RC_3c0d20260cc8c66bb46ae8f7e84cc398</code> that represents <code>Quantity_SumRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: Quantity_SumRecord
public partial struct RC_3c0d20260cc8c66bb46ae8f7e84cc398 : ITypedRecord<RC_3c0d20260cc8c66bb46ae8f7e84cc398> {
internal static readonly GlobalObjectKey IdQuantity_Sum = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*JiANPMgMa8a0auj36EzDmA");

public decimal ssQuantity_Sum;


public BitArray OptimizedAttributes;

public RC_3c0d20260cc8c66bb46ae8f7e84cc398() {
OptimizedAttributes = null;
ssQuantity_Sum = 0.0M;
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
ssQuantity_Sum = r.ReadDecimal(index++, "Quantity_SumRecord.Quantity_Sum", 0.0M);
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
public void ReadIM(RC_3c0d20260cc8c66bb46ae8f7e84cc398 r) {
this = r;
}


public static bool operator == (RC_3c0d20260cc8c66bb46ae8f7e84cc398 a, RC_3c0d20260cc8c66bb46ae8f7e84cc398 b) {
if (a.ssQuantity_Sum != b.ssQuantity_Sum) return false;
return true;
}

public static bool operator != (RC_3c0d20260cc8c66bb46ae8f7e84cc398 a, RC_3c0d20260cc8c66bb46ae8f7e84cc398 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3c0d20260cc8c66bb46ae8f7e84cc398)) return false;
return (this == (RC_3c0d20260cc8c66bb46ae8f7e84cc398)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssQuantity_Sum.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_3c0d20260cc8c66bb46ae8f7e84cc398 Duplicate() {
RC_3c0d20260cc8c66bb46ae8f7e84cc398 t;
t.ssQuantity_Sum = this.ssQuantity_Sum;
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
if (head == "quantity_sum") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Quantity_Sum")) variable.Value = ssQuantity_Sum; else variable.Optimized = true;
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
if (key == IdQuantity_Sum) {
return ssQuantity_Sum;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdQuantity_Sum.Key.AsGuid) {
return ssQuantity_Sum;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssQuantity_Sum = (decimal) other.AttributeGet(IdQuantity_Sum);
}
} // RC_3c0d20260cc8c66bb46ae8f7e84cc398
/// <summary>
/// RecordList type <code>Quantity_SumRecordList</code> that represents a record list of
///  <code>Decimal</code>
/// </summary>
public partial class RL_d8fbadd9d27fdb0e62381fbcaf364158 : GenericRecordList<RC_3c0d20260cc8c66bb46ae8f7e84cc398>, IEnumerable, IEnumerator {

protected override RC_3c0d20260cc8c66bb46ae8f7e84cc398 GetElementDefaultValue() {
return new RC_3c0d20260cc8c66bb46ae8f7e84cc398();
}

public T[] ToArray<T>(Func<RC_3c0d20260cc8c66bb46ae8f7e84cc398, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d8fbadd9d27fdb0e62381fbcaf364158 recordList, Func<RC_3c0d20260cc8c66bb46ae8f7e84cc398, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d8fbadd9d27fdb0e62381fbcaf364158(RC_3c0d20260cc8c66bb46ae8f7e84cc398[] array) {
  RL_d8fbadd9d27fdb0e62381fbcaf364158 result = new RL_d8fbadd9d27fdb0e62381fbcaf364158();
result.InnerFromArray(array);
    return result;
}

public static RL_d8fbadd9d27fdb0e62381fbcaf364158 ToList<T>(T[] array, Func <T, RC_3c0d20260cc8c66bb46ae8f7e84cc398> converter) {
  RL_d8fbadd9d27fdb0e62381fbcaf364158 result = new RL_d8fbadd9d27fdb0e62381fbcaf364158();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d8fbadd9d27fdb0e62381fbcaf364158 FromRestList<T>(RestList<T> restList, Func <T, RC_3c0d20260cc8c66bb46ae8f7e84cc398> converter) {
  RL_d8fbadd9d27fdb0e62381fbcaf364158 result = new RL_d8fbadd9d27fdb0e62381fbcaf364158();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d8fbadd9d27fdb0e62381fbcaf364158() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3c0d20260cc8c66bb46ae8f7e84cc398> NewList() {
return new RL_d8fbadd9d27fdb0e62381fbcaf364158();
}


} // RL_d8fbadd9d27fdb0e62381fbcaf364158
}

