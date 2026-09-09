namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (bI+H0Skakk6rhvSp6WGsEA)
///  <code>RC_de8617412b322377b0b7d994b41f18b6</code> that represent
/// s <code>ValidationReportRecord</code> <p>Description: </p>
/// </summary>
// Name: ValidationReportRecord
public partial struct RC_de8617412b322377b0b7d994b41f18b6 : ITypedRecord<RC_de8617412b322377b0b7d994b41f18b6> {
internal static readonly GlobalObjectKey IdValidationReport = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QReG3jIrdyOwt9mUtB8Ytg");

public ST_f54c1d1bac41c2667837ac97bb484830Structure ssSTValidationReport;


public static implicit operator ST_f54c1d1bac41c2667837ac97bb484830Structure( RC_de8617412b322377b0b7d994b41f18b6 r) {
return r.ssSTValidationReport;
}

public static implicit operator RC_de8617412b322377b0b7d994b41f18b6 (ST_f54c1d1bac41c2667837ac97bb484830Structure r) {
RC_de8617412b322377b0b7d994b41f18b6 res = new RC_de8617412b322377b0b7d994b41f18b6 ();
res.ssSTValidationReport = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_de8617412b322377b0b7d994b41f18b6() {
OptimizedAttributes = null;
ssSTValidationReport = new ST_f54c1d1bac41c2667837ac97bb484830Structure();
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
    ssSTValidationReport.OptimizedAttributes = value[0];
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
ssSTValidationReport.Read( r, ref index);
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
public void ReadIM(RC_de8617412b322377b0b7d994b41f18b6 r) {
this = r;
}


public static bool operator == (RC_de8617412b322377b0b7d994b41f18b6 a, RC_de8617412b322377b0b7d994b41f18b6 b) {
if (a.ssSTValidationReport != b.ssSTValidationReport) return false;
return true;
}

public static bool operator != (RC_de8617412b322377b0b7d994b41f18b6 a, RC_de8617412b322377b0b7d994b41f18b6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_de8617412b322377b0b7d994b41f18b6)) return false;
return (this == (RC_de8617412b322377b0b7d994b41f18b6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTValidationReport.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTValidationReport.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTValidationReport.InternalRecursiveSave();
}


public RC_de8617412b322377b0b7d994b41f18b6 Duplicate() {
RC_de8617412b322377b0b7d994b41f18b6 t;
t.ssSTValidationReport = (ST_f54c1d1bac41c2667837ac97bb484830Structure)this.ssSTValidationReport.Duplicate();
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
if (head == "validationreport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ValidationReport")) variable.Value = ssSTValidationReport; else variable.Optimized = true;
variable.SetFieldName("validationreport");
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
if (key == IdValidationReport) {
return ssSTValidationReport;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValidationReport.Key.AsGuid) {
return ssSTValidationReport;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTValidationReport.FillFromOther((IRecord) other.AttributeGet(IdValidationReport));
}
} // RC_de8617412b322377b0b7d994b41f18b6
/// <summary>
/// RecordList type <code>ValidationReportRecordList</code> that represents a record list of
///  <code>ValidationReport</code>
/// </summary>
public partial class RL_f5b190b4fc59e60d67bb5e03b6e457d2 : GenericRecordList<RC_de8617412b322377b0b7d994b41f18b6>, IEnumerable, IEnumerator {

protected override RC_de8617412b322377b0b7d994b41f18b6 GetElementDefaultValue() {
return new RC_de8617412b322377b0b7d994b41f18b6();
}

public T[] ToArray<T>(Func<RC_de8617412b322377b0b7d994b41f18b6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f5b190b4fc59e60d67bb5e03b6e457d2 recordList, Func<RC_de8617412b322377b0b7d994b41f18b6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f5b190b4fc59e60d67bb5e03b6e457d2(RC_de8617412b322377b0b7d994b41f18b6[] array) {
  RL_f5b190b4fc59e60d67bb5e03b6e457d2 result = new RL_f5b190b4fc59e60d67bb5e03b6e457d2();
result.InnerFromArray(array);
    return result;
}

public static RL_f5b190b4fc59e60d67bb5e03b6e457d2 ToList<T>(T[] array, Func <T, RC_de8617412b322377b0b7d994b41f18b6> converter) {
  RL_f5b190b4fc59e60d67bb5e03b6e457d2 result = new RL_f5b190b4fc59e60d67bb5e03b6e457d2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f5b190b4fc59e60d67bb5e03b6e457d2 FromRestList<T>(RestList<T> restList, Func <T, RC_de8617412b322377b0b7d994b41f18b6> converter) {
  RL_f5b190b4fc59e60d67bb5e03b6e457d2 result = new RL_f5b190b4fc59e60d67bb5e03b6e457d2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f5b190b4fc59e60d67bb5e03b6e457d2() : base() {
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
protected override OSList<RC_de8617412b322377b0b7d994b41f18b6> NewList() {
return new RL_f5b190b4fc59e60d67bb5e03b6e457d2();
}


} // RL_f5b190b4fc59e60d67bb5e03b6e457d2
}

