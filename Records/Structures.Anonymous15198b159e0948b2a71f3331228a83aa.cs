namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (FYsZFQmeskinHzMxIoqDqg)
///  <code>RC_769d8d99752cec679c1c2bc7970a5749</code> that represent
/// s <code>ExcelOrderEntriesLogToExportRecord</code> <p>Description: </p>
/// </summary>
// Name: ExcelOrderEntriesLogToExportRecord
public partial struct RC_769d8d99752cec679c1c2bc7970a5749 : ITypedRecord<RC_769d8d99752cec679c1c2bc7970a5749> {
internal static readonly GlobalObjectKey IdExcelOrderEntriesLogToExport = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*mY2ddix1Z+ycHCvHlwpXSQ");

public ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure ssSTExcelOrderEntriesLogToExport;


public static implicit operator ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure( RC_769d8d99752cec679c1c2bc7970a5749 r) {
return r.ssSTExcelOrderEntriesLogToExport;
}

public static implicit operator RC_769d8d99752cec679c1c2bc7970a5749 (ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure r) {
RC_769d8d99752cec679c1c2bc7970a5749 res = new RC_769d8d99752cec679c1c2bc7970a5749 ();
res.ssSTExcelOrderEntriesLogToExport = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_769d8d99752cec679c1c2bc7970a5749() {
OptimizedAttributes = null;
ssSTExcelOrderEntriesLogToExport = new ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTExcelOrderEntriesLogToExport.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTExcelOrderEntriesLogToExport.Read( r, ref index);
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
public void ReadIM(RC_769d8d99752cec679c1c2bc7970a5749 r) {
this = r;
}


public static bool operator == (RC_769d8d99752cec679c1c2bc7970a5749 a, RC_769d8d99752cec679c1c2bc7970a5749 b) {
if (a.ssSTExcelOrderEntriesLogToExport != b.ssSTExcelOrderEntriesLogToExport) return false;
return true;
}

public static bool operator != (RC_769d8d99752cec679c1c2bc7970a5749 a, RC_769d8d99752cec679c1c2bc7970a5749 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_769d8d99752cec679c1c2bc7970a5749)) return false;
return (this == (RC_769d8d99752cec679c1c2bc7970a5749)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTExcelOrderEntriesLogToExport.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTExcelOrderEntriesLogToExport.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTExcelOrderEntriesLogToExport.InternalRecursiveSave();
}


public RC_769d8d99752cec679c1c2bc7970a5749 Duplicate() {
RC_769d8d99752cec679c1c2bc7970a5749 t;
t.ssSTExcelOrderEntriesLogToExport = (ST_8a84c0565c68734bf5e2c1c8f79fe30cStructure)this.ssSTExcelOrderEntriesLogToExport.Duplicate();
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
if (head == "excelorderentrieslogtoexport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExcelOrderEntriesLogToExport")) variable.Value = ssSTExcelOrderEntriesLogToExport; else variable.Optimized = true;
variable.SetFieldName("excelorderentrieslogtoexport");
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
if (key == IdExcelOrderEntriesLogToExport) {
return ssSTExcelOrderEntriesLogToExport;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdExcelOrderEntriesLogToExport.Key.AsGuid) {
return ssSTExcelOrderEntriesLogToExport;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTExcelOrderEntriesLogToExport.FillFromOther((IRecord) other.AttributeGet(IdExcelOrderEntriesLogToExport));
}
} // RC_769d8d99752cec679c1c2bc7970a5749
/// <summary>
/// RecordList type <code>ExcelOrderEntriesLogToExportRecordList</code> that represents a record list
///  of <code>ExcelOrderEntriesLogToExport</code>
/// </summary>
public partial class RL_923b95316653c81a91b07459a59f48a8 : GenericRecordList<RC_769d8d99752cec679c1c2bc7970a5749>, IEnumerable, IEnumerator {

protected override RC_769d8d99752cec679c1c2bc7970a5749 GetElementDefaultValue() {
return new RC_769d8d99752cec679c1c2bc7970a5749();
}

public T[] ToArray<T>(Func<RC_769d8d99752cec679c1c2bc7970a5749, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_923b95316653c81a91b07459a59f48a8 recordList, Func<RC_769d8d99752cec679c1c2bc7970a5749, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_923b95316653c81a91b07459a59f48a8(RC_769d8d99752cec679c1c2bc7970a5749[] array) {
  RL_923b95316653c81a91b07459a59f48a8 result = new RL_923b95316653c81a91b07459a59f48a8();
result.InnerFromArray(array);
    return result;
}

public static RL_923b95316653c81a91b07459a59f48a8 ToList<T>(T[] array, Func <T, RC_769d8d99752cec679c1c2bc7970a5749> converter) {
  RL_923b95316653c81a91b07459a59f48a8 result = new RL_923b95316653c81a91b07459a59f48a8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_923b95316653c81a91b07459a59f48a8 FromRestList<T>(RestList<T> restList, Func <T, RC_769d8d99752cec679c1c2bc7970a5749> converter) {
  RL_923b95316653c81a91b07459a59f48a8 result = new RL_923b95316653c81a91b07459a59f48a8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_923b95316653c81a91b07459a59f48a8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_769d8d99752cec679c1c2bc7970a5749> NewList() {
return new RL_923b95316653c81a91b07459a59f48a8();
}


} // RL_923b95316653c81a91b07459a59f48a8
}

