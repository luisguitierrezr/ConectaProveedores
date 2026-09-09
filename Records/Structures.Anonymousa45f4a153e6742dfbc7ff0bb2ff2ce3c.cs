namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (FUpfpGc+30K8f_C7L_LOPA)
///  <code>RC_8a90e407fd43eda7eb201f767dcc2beb</code> that represent
/// s <code>ExcelProposalLogToExportRecord</code> <p>Description: </p>
/// </summary>
// Name: ExcelProposalLogToExportRecord
public partial struct RC_8a90e407fd43eda7eb201f767dcc2beb : ITypedRecord<RC_8a90e407fd43eda7eb201f767dcc2beb> {
internal static readonly GlobalObjectKey IdExcelProposalLogToExport = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*B+SQikP9p+3rIB92fcwr6w");

public ST_d9d3688bd2889652b9e8e27acc05ba6cStructure ssSTExcelProposalLogToExport;


public static implicit operator ST_d9d3688bd2889652b9e8e27acc05ba6cStructure( RC_8a90e407fd43eda7eb201f767dcc2beb r) {
return r.ssSTExcelProposalLogToExport;
}

public static implicit operator RC_8a90e407fd43eda7eb201f767dcc2beb (ST_d9d3688bd2889652b9e8e27acc05ba6cStructure r) {
RC_8a90e407fd43eda7eb201f767dcc2beb res = new RC_8a90e407fd43eda7eb201f767dcc2beb ();
res.ssSTExcelProposalLogToExport = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_8a90e407fd43eda7eb201f767dcc2beb() {
OptimizedAttributes = null;
ssSTExcelProposalLogToExport = new ST_d9d3688bd2889652b9e8e27acc05ba6cStructure();
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
    ssSTExcelProposalLogToExport.OptimizedAttributes = value[0];
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
ssSTExcelProposalLogToExport.Read( r, ref index);
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
public void ReadIM(RC_8a90e407fd43eda7eb201f767dcc2beb r) {
this = r;
}


public static bool operator == (RC_8a90e407fd43eda7eb201f767dcc2beb a, RC_8a90e407fd43eda7eb201f767dcc2beb b) {
if (a.ssSTExcelProposalLogToExport != b.ssSTExcelProposalLogToExport) return false;
return true;
}

public static bool operator != (RC_8a90e407fd43eda7eb201f767dcc2beb a, RC_8a90e407fd43eda7eb201f767dcc2beb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8a90e407fd43eda7eb201f767dcc2beb)) return false;
return (this == (RC_8a90e407fd43eda7eb201f767dcc2beb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTExcelProposalLogToExport.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTExcelProposalLogToExport.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTExcelProposalLogToExport.InternalRecursiveSave();
}


public RC_8a90e407fd43eda7eb201f767dcc2beb Duplicate() {
RC_8a90e407fd43eda7eb201f767dcc2beb t;
t.ssSTExcelProposalLogToExport = (ST_d9d3688bd2889652b9e8e27acc05ba6cStructure)this.ssSTExcelProposalLogToExport.Duplicate();
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
if (head == "excelproposallogtoexport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExcelProposalLogToExport")) variable.Value = ssSTExcelProposalLogToExport; else variable.Optimized = true;
variable.SetFieldName("excelproposallogtoexport");
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
if (key == IdExcelProposalLogToExport) {
return ssSTExcelProposalLogToExport;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdExcelProposalLogToExport.Key.AsGuid) {
return ssSTExcelProposalLogToExport;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTExcelProposalLogToExport.FillFromOther((IRecord) other.AttributeGet(IdExcelProposalLogToExport));
}
} // RC_8a90e407fd43eda7eb201f767dcc2beb
/// <summary>
/// RecordList type <code>ExcelProposalLogToExportRecordList</code> that represents a record list of
///  <code>ExcelProposalLogToExport</code>
/// </summary>
public partial class RL_a3dffba3fa7832831471b652c3e3b26f : GenericRecordList<RC_8a90e407fd43eda7eb201f767dcc2beb>, IEnumerable, IEnumerator {

protected override RC_8a90e407fd43eda7eb201f767dcc2beb GetElementDefaultValue() {
return new RC_8a90e407fd43eda7eb201f767dcc2beb();
}

public T[] ToArray<T>(Func<RC_8a90e407fd43eda7eb201f767dcc2beb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a3dffba3fa7832831471b652c3e3b26f recordList, Func<RC_8a90e407fd43eda7eb201f767dcc2beb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a3dffba3fa7832831471b652c3e3b26f(RC_8a90e407fd43eda7eb201f767dcc2beb[] array) {
  RL_a3dffba3fa7832831471b652c3e3b26f result = new RL_a3dffba3fa7832831471b652c3e3b26f();
result.InnerFromArray(array);
    return result;
}

public static RL_a3dffba3fa7832831471b652c3e3b26f ToList<T>(T[] array, Func <T, RC_8a90e407fd43eda7eb201f767dcc2beb> converter) {
  RL_a3dffba3fa7832831471b652c3e3b26f result = new RL_a3dffba3fa7832831471b652c3e3b26f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a3dffba3fa7832831471b652c3e3b26f FromRestList<T>(RestList<T> restList, Func <T, RC_8a90e407fd43eda7eb201f767dcc2beb> converter) {
  RL_a3dffba3fa7832831471b652c3e3b26f result = new RL_a3dffba3fa7832831471b652c3e3b26f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a3dffba3fa7832831471b652c3e3b26f() : base() {
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
protected override OSList<RC_8a90e407fd43eda7eb201f767dcc2beb> NewList() {
return new RL_a3dffba3fa7832831471b652c3e3b26f();
}


} // RL_a3dffba3fa7832831471b652c3e3b26f
}

