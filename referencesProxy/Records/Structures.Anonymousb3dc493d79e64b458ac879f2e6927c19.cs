namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (PUncs+Z5RUuKyHny5pJ8GQ)
///  <code>RC_341c7b677aa5a51a40f72189133871ba</code> that represent
/// s <code>FiscalYearExceptionsRecord</code> <p>Description: </p>
/// </summary>
// Name: FiscalYearExceptionsRecord
public partial struct RC_341c7b677aa5a51a40f72189133871ba : ITypedRecord<RC_341c7b677aa5a51a40f72189133871ba> {
internal static readonly GlobalObjectKey IdFiscalYearExceptions = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Z3scNKV6GqVA9yGJEzhxug");

public EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord ssENFiscalYearExceptions;


public static implicit operator EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord( RC_341c7b677aa5a51a40f72189133871ba r) {
return r.ssENFiscalYearExceptions;
}

public static implicit operator RC_341c7b677aa5a51a40f72189133871ba (EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord r) {
RC_341c7b677aa5a51a40f72189133871ba res = new RC_341c7b677aa5a51a40f72189133871ba ();
res.ssENFiscalYearExceptions = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFiscalYearExceptions.ChangedAttributes = value;
}
get {
    return ssENFiscalYearExceptions.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_341c7b677aa5a51a40f72189133871ba() {
OptimizedAttributes = null;
ssENFiscalYearExceptions = new EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFiscalYearExceptions.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFiscalYearExceptions.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFiscalYearExceptions.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFiscalYearExceptions.Read( r, ref index);
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
public void ReadIM(RC_341c7b677aa5a51a40f72189133871ba r) {
this = r;
}


public static bool operator == (RC_341c7b677aa5a51a40f72189133871ba a, RC_341c7b677aa5a51a40f72189133871ba b) {
if (a.ssENFiscalYearExceptions != b.ssENFiscalYearExceptions) return false;
return true;
}

public static bool operator != (RC_341c7b677aa5a51a40f72189133871ba a, RC_341c7b677aa5a51a40f72189133871ba b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_341c7b677aa5a51a40f72189133871ba)) return false;
return (this == (RC_341c7b677aa5a51a40f72189133871ba)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFiscalYearExceptions.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFiscalYearExceptions.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFiscalYearExceptions.InternalRecursiveSave();
}


public RC_341c7b677aa5a51a40f72189133871ba Duplicate() {
RC_341c7b677aa5a51a40f72189133871ba t;
t.ssENFiscalYearExceptions = (EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord)this.ssENFiscalYearExceptions.Duplicate();
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
if (head == "fiscalyearexceptions") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FiscalYearExceptions")) variable.Value = ssENFiscalYearExceptions; else variable.Optimized = true;
variable.SetFieldName("fiscalyearexceptions");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFiscalYearExceptions.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFiscalYearExceptions.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFiscalYearExceptions) {
return ssENFiscalYearExceptions;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFiscalYearExceptions.Key.AsGuid) {
return ssENFiscalYearExceptions;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFiscalYearExceptions.FillFromOther((IRecord) other.AttributeGet(IdFiscalYearExceptions));
}
} // RC_341c7b677aa5a51a40f72189133871ba
/// <summary>
/// RecordList type <code>FiscalYearExceptionsRecordList</code> that represents a record list of
///  <code>FiscalYearExceptions</code>
/// </summary>
public partial class RL_8e032f44e0be6aa532cdb4d35c4de633 : GenericRecordList<RC_341c7b677aa5a51a40f72189133871ba>, IEnumerable, IEnumerator {

protected override RC_341c7b677aa5a51a40f72189133871ba GetElementDefaultValue() {
return new RC_341c7b677aa5a51a40f72189133871ba();
}

public T[] ToArray<T>(Func<RC_341c7b677aa5a51a40f72189133871ba, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8e032f44e0be6aa532cdb4d35c4de633 recordList, Func<RC_341c7b677aa5a51a40f72189133871ba, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8e032f44e0be6aa532cdb4d35c4de633(RC_341c7b677aa5a51a40f72189133871ba[] array) {
  RL_8e032f44e0be6aa532cdb4d35c4de633 result = new RL_8e032f44e0be6aa532cdb4d35c4de633();
result.InnerFromArray(array);
    return result;
}

public static RL_8e032f44e0be6aa532cdb4d35c4de633 ToList<T>(T[] array, Func <T, RC_341c7b677aa5a51a40f72189133871ba> converter) {
  RL_8e032f44e0be6aa532cdb4d35c4de633 result = new RL_8e032f44e0be6aa532cdb4d35c4de633();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8e032f44e0be6aa532cdb4d35c4de633 FromRestList<T>(RestList<T> restList, Func <T, RC_341c7b677aa5a51a40f72189133871ba> converter) {
  RL_8e032f44e0be6aa532cdb4d35c4de633 result = new RL_8e032f44e0be6aa532cdb4d35c4de633();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8e032f44e0be6aa532cdb4d35c4de633() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_341c7b677aa5a51a40f72189133871ba> NewList() {
return new RL_8e032f44e0be6aa532cdb4d35c4de633();
}


} // RL_8e032f44e0be6aa532cdb4d35c4de633
}

