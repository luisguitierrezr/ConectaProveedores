namespace ssConectaProveedores {
/// <summary>
/// [Structure] Rows (eXCszDtZ8kS3kRO2hFa0kQ) <code>ST_3fd667dc2513888f6027df59e05def3fStructure</code>
///  that represents <code>Rows</code> <p>Description: </p>
/// </summary>
// Name: Rows
public partial struct ST_3fd667dc2513888f6027df59e05def3fStructure : ITypedRecord<ST_3fd667dc2513888f6027df59e05def3fStructure> {
internal static readonly GlobalObjectKey IdRowNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BmSBd+23M0mybIiewEMZyw");
internal static readonly GlobalObjectKey IdQuantity = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*CdEvFBgZIEOKr8tw5jY3WA");

public long ssRowNumber;

public decimal ssQuantity;


public BitArray OptimizedAttributes;

public ST_3fd667dc2513888f6027df59e05def3fStructure() {
OptimizedAttributes = null;
ssRowNumber = 0L;
ssQuantity = 0.0M;
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
ssRowNumber = r.ReadLongInteger(index++, "Rows.RowNumber", 0L);
ssQuantity = r.ReadDecimal(index++, "Rows.Quantity", 0.0M);
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
public void ReadIM(ST_3fd667dc2513888f6027df59e05def3fStructure r) {
this = r;
}


public static bool operator == (ST_3fd667dc2513888f6027df59e05def3fStructure a, ST_3fd667dc2513888f6027df59e05def3fStructure b) {
if (a.ssRowNumber != b.ssRowNumber) return false;
if (a.ssQuantity != b.ssQuantity) return false;
return true;
}

public static bool operator != (ST_3fd667dc2513888f6027df59e05def3fStructure a, ST_3fd667dc2513888f6027df59e05def3fStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_3fd667dc2513888f6027df59e05def3fStructure)) return false;
return (this == (ST_3fd667dc2513888f6027df59e05def3fStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssRowNumber.GetHashCode()
 ^ ssQuantity.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_3fd667dc2513888f6027df59e05def3fStructure Duplicate() {
ST_3fd667dc2513888f6027df59e05def3fStructure t;
t.ssRowNumber = this.ssRowNumber;
t.ssQuantity = this.ssQuantity;
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
if (head == "rownumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RowNumber")) variable.Value = ssRowNumber; else variable.Optimized = true;
} else if (head == "quantity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Quantity")) variable.Value = ssQuantity; else variable.Optimized = true;
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
if (key == IdRowNumber) {
return ssRowNumber;
}
if (key == IdQuantity) {
return ssQuantity;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRowNumber.Key.AsGuid) {
return ssRowNumber;
}
if (attributeKey == IdQuantity.Key.AsGuid) {
return ssQuantity;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssRowNumber = (long) other.AttributeGet(IdRowNumber);
ssQuantity = (decimal) other.AttributeGet(IdQuantity);
}
} // ST_3fd667dc2513888f6027df59e05def3fStructure
/// <summary>
/// RecordList type <code>RowsList</code> that represents a record list of <code>Rows</code>
/// </summary>
public partial class RL_800c0b51440fd41c56528d60815ca788 : GenericRecordList<ST_3fd667dc2513888f6027df59e05def3fStructure>, IEnumerable, IEnumerator {

protected override ST_3fd667dc2513888f6027df59e05def3fStructure GetElementDefaultValue() {
return new ST_3fd667dc2513888f6027df59e05def3fStructure();
}

public T[] ToArray<T>(Func<ST_3fd667dc2513888f6027df59e05def3fStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_800c0b51440fd41c56528d60815ca788 recordList, Func<ST_3fd667dc2513888f6027df59e05def3fStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_800c0b51440fd41c56528d60815ca788(ST_3fd667dc2513888f6027df59e05def3fStructure[] array) {
  RL_800c0b51440fd41c56528d60815ca788 result = new RL_800c0b51440fd41c56528d60815ca788();
result.InnerFromArray(array);
    return result;
}

public static RL_800c0b51440fd41c56528d60815ca788 ToList<T>(T[] array, Func <T, ST_3fd667dc2513888f6027df59e05def3fStructure> converter) {
  RL_800c0b51440fd41c56528d60815ca788 result = new RL_800c0b51440fd41c56528d60815ca788();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_800c0b51440fd41c56528d60815ca788 FromRestList<T>(RestList<T> restList, Func <T, ST_3fd667dc2513888f6027df59e05def3fStructure> converter) {
  RL_800c0b51440fd41c56528d60815ca788 result = new RL_800c0b51440fd41c56528d60815ca788();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_800c0b51440fd41c56528d60815ca788() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_3fd667dc2513888f6027df59e05def3fStructure> NewList() {
return new RL_800c0b51440fd41c56528d60815ca788();
}


} // RL_800c0b51440fd41c56528d60815ca788
}

