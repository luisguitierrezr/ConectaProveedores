namespace ssConectaProveedores {
/// <summary>
/// [Structure] OrderTemp (kvOZnysGyk6xbCjFz83vjA)
///  <code>ST_9b020d447acc32d28b5e58ce81130d00Structure</code> that represents <code>OrderTemp</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderTemp
public partial struct ST_9b020d447acc32d28b5e58ce81130d00Structure : ITypedRecord<ST_9b020d447acc32d28b5e58ce81130d00Structure> {
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DSWRiNvV6EmAf3SOLSf9kw");

public string ssTotalAmount;


public BitArray OptimizedAttributes;

public ST_9b020d447acc32d28b5e58ce81130d00Structure() {
OptimizedAttributes = null;
ssTotalAmount = "";
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
ssTotalAmount = r.ReadText(index++, "OrderTemp.TotalAmount", "");
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
public void ReadIM(ST_9b020d447acc32d28b5e58ce81130d00Structure r) {
this = r;
}


public static bool operator == (ST_9b020d447acc32d28b5e58ce81130d00Structure a, ST_9b020d447acc32d28b5e58ce81130d00Structure b) {
if (a.ssTotalAmount != b.ssTotalAmount) return false;
return true;
}

public static bool operator != (ST_9b020d447acc32d28b5e58ce81130d00Structure a, ST_9b020d447acc32d28b5e58ce81130d00Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_9b020d447acc32d28b5e58ce81130d00Structure)) return false;
return (this == (ST_9b020d447acc32d28b5e58ce81130d00Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_9b020d447acc32d28b5e58ce81130d00Structure Duplicate() {
ST_9b020d447acc32d28b5e58ce81130d00Structure t;
t.ssTotalAmount = this.ssTotalAmount;
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
if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
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
if (key == IdTotalAmount) {
return ssTotalAmount;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssTotalAmount = (string) other.AttributeGet(IdTotalAmount);
}
} // ST_9b020d447acc32d28b5e58ce81130d00Structure
/// <summary>
/// RecordList type <code>OrderTempList</code> that represents a record list of <code>OrderTemp</code>
/// </summary>
public partial class RL_969fadd2883b64f3cab208a68a02d6f1 : GenericRecordList<ST_9b020d447acc32d28b5e58ce81130d00Structure>, IEnumerable, IEnumerator {

protected override ST_9b020d447acc32d28b5e58ce81130d00Structure GetElementDefaultValue() {
return new ST_9b020d447acc32d28b5e58ce81130d00Structure();
}

public T[] ToArray<T>(Func<ST_9b020d447acc32d28b5e58ce81130d00Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_969fadd2883b64f3cab208a68a02d6f1 recordList, Func<ST_9b020d447acc32d28b5e58ce81130d00Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_969fadd2883b64f3cab208a68a02d6f1(ST_9b020d447acc32d28b5e58ce81130d00Structure[] array) {
  RL_969fadd2883b64f3cab208a68a02d6f1 result = new RL_969fadd2883b64f3cab208a68a02d6f1();
result.InnerFromArray(array);
    return result;
}

public static RL_969fadd2883b64f3cab208a68a02d6f1 ToList<T>(T[] array, Func <T, ST_9b020d447acc32d28b5e58ce81130d00Structure> converter) {
  RL_969fadd2883b64f3cab208a68a02d6f1 result = new RL_969fadd2883b64f3cab208a68a02d6f1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_969fadd2883b64f3cab208a68a02d6f1 FromRestList<T>(RestList<T> restList, Func <T, ST_9b020d447acc32d28b5e58ce81130d00Structure> converter) {
  RL_969fadd2883b64f3cab208a68a02d6f1 result = new RL_969fadd2883b64f3cab208a68a02d6f1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_969fadd2883b64f3cab208a68a02d6f1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_9b020d447acc32d28b5e58ce81130d00Structure> NewList() {
return new RL_969fadd2883b64f3cab208a68a02d6f1();
}


} // RL_969fadd2883b64f3cab208a68a02d6f1
}

