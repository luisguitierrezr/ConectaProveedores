namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (5BQyCF1qsk2U8wutCGPmsQ)
///  <code>RC_6c3703fd5f299efe93690e66a0547b14</code> that represent
/// s <code>ImportAccountingExcelStructRecord</code> <p>Description: </p>
/// </summary>
// Name: ImportAccountingExcelStructRecord
public partial struct RC_6c3703fd5f299efe93690e66a0547b14 : ITypedRecord<RC_6c3703fd5f299efe93690e66a0547b14> {
internal static readonly GlobalObjectKey IdImportAccountingExcelStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_QM3bClf_p6TaQ5moFR7FA");

public ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure ssSTImportAccountingExcelStruct;


public static implicit operator ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure( RC_6c3703fd5f299efe93690e66a0547b14 r) {
return r.ssSTImportAccountingExcelStruct;
}

public static implicit operator RC_6c3703fd5f299efe93690e66a0547b14 (ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure r) {
RC_6c3703fd5f299efe93690e66a0547b14 res = new RC_6c3703fd5f299efe93690e66a0547b14 ();
res.ssSTImportAccountingExcelStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_6c3703fd5f299efe93690e66a0547b14() {
OptimizedAttributes = null;
ssSTImportAccountingExcelStruct = new ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure();
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
    ssSTImportAccountingExcelStruct.OptimizedAttributes = value[0];
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
ssSTImportAccountingExcelStruct.Read( r, ref index);
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
public void ReadIM(RC_6c3703fd5f299efe93690e66a0547b14 r) {
this = r;
}


public static bool operator == (RC_6c3703fd5f299efe93690e66a0547b14 a, RC_6c3703fd5f299efe93690e66a0547b14 b) {
if (a.ssSTImportAccountingExcelStruct != b.ssSTImportAccountingExcelStruct) return false;
return true;
}

public static bool operator != (RC_6c3703fd5f299efe93690e66a0547b14 a, RC_6c3703fd5f299efe93690e66a0547b14 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6c3703fd5f299efe93690e66a0547b14)) return false;
return (this == (RC_6c3703fd5f299efe93690e66a0547b14)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTImportAccountingExcelStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTImportAccountingExcelStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTImportAccountingExcelStruct.InternalRecursiveSave();
}


public RC_6c3703fd5f299efe93690e66a0547b14 Duplicate() {
RC_6c3703fd5f299efe93690e66a0547b14 t;
t.ssSTImportAccountingExcelStruct = (ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure)this.ssSTImportAccountingExcelStruct.Duplicate();
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
if (head == "importaccountingexcelstruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImportAccountingExcelStruct")) variable.Value = ssSTImportAccountingExcelStruct; else variable.Optimized = true;
variable.SetFieldName("importaccountingexcelstruct");
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
if (key == IdImportAccountingExcelStruct) {
return ssSTImportAccountingExcelStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdImportAccountingExcelStruct.Key.AsGuid) {
return ssSTImportAccountingExcelStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTImportAccountingExcelStruct.FillFromOther((IRecord) other.AttributeGet(IdImportAccountingExcelStruct));
}
} // RC_6c3703fd5f299efe93690e66a0547b14
/// <summary>
/// RecordList type <code>ImportAccountingExcelStructRecordList</code> that represents a record list of
///  <code>ImportAccountingExcelStruct</code>
/// </summary>
public partial class RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d : GenericRecordList<RC_6c3703fd5f299efe93690e66a0547b14>, IEnumerable, IEnumerator {

protected override RC_6c3703fd5f299efe93690e66a0547b14 GetElementDefaultValue() {
return new RC_6c3703fd5f299efe93690e66a0547b14();
}

public T[] ToArray<T>(Func<RC_6c3703fd5f299efe93690e66a0547b14, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d recordList, Func<RC_6c3703fd5f299efe93690e66a0547b14, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d(RC_6c3703fd5f299efe93690e66a0547b14[] array) {
  RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d result = new RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d();
result.InnerFromArray(array);
    return result;
}

public static RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d ToList<T>(T[] array, Func <T, RC_6c3703fd5f299efe93690e66a0547b14> converter) {
  RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d result = new RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d FromRestList<T>(RestList<T> restList, Func <T, RC_6c3703fd5f299efe93690e66a0547b14> converter) {
  RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d result = new RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d() : base() {
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
protected override OSList<RC_6c3703fd5f299efe93690e66a0547b14> NewList() {
return new RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d();
}


} // RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d
}

