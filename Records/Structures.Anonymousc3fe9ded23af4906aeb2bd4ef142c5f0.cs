namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (7Z3+w68jBkmusr1O8ULF8A)
///  <code>RC_b75e1542aa6c3f9562684d933180c07c</code> that represent
/// s <code>GetErrorDistributionOutStructureRecord</code> <p>Description: </p>
/// </summary>
// Name: GetErrorDistributionOutStructureRecord
public partial struct RC_b75e1542aa6c3f9562684d933180c07c : ITypedRecord<RC_b75e1542aa6c3f9562684d933180c07c> {
internal static readonly GlobalObjectKey IdGetErrorDistributionOutStructure = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QhVet2yqlT9iaE2TMYDAfA");

public ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure ssSTGetErrorDistributionOutStructure;


public static implicit operator ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure( RC_b75e1542aa6c3f9562684d933180c07c r) {
return r.ssSTGetErrorDistributionOutStructure;
}

public static implicit operator RC_b75e1542aa6c3f9562684d933180c07c (ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure r) {
RC_b75e1542aa6c3f9562684d933180c07c res = new RC_b75e1542aa6c3f9562684d933180c07c ();
res.ssSTGetErrorDistributionOutStructure = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b75e1542aa6c3f9562684d933180c07c() {
OptimizedAttributes = null;
ssSTGetErrorDistributionOutStructure = new ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure();
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
    ssSTGetErrorDistributionOutStructure.OptimizedAttributes = value[0];
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
ssSTGetErrorDistributionOutStructure.Read( r, ref index);
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
public void ReadIM(RC_b75e1542aa6c3f9562684d933180c07c r) {
this = r;
}


public static bool operator == (RC_b75e1542aa6c3f9562684d933180c07c a, RC_b75e1542aa6c3f9562684d933180c07c b) {
if (a.ssSTGetErrorDistributionOutStructure != b.ssSTGetErrorDistributionOutStructure) return false;
return true;
}

public static bool operator != (RC_b75e1542aa6c3f9562684d933180c07c a, RC_b75e1542aa6c3f9562684d933180c07c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b75e1542aa6c3f9562684d933180c07c)) return false;
return (this == (RC_b75e1542aa6c3f9562684d933180c07c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTGetErrorDistributionOutStructure.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTGetErrorDistributionOutStructure.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTGetErrorDistributionOutStructure.InternalRecursiveSave();
}


public RC_b75e1542aa6c3f9562684d933180c07c Duplicate() {
RC_b75e1542aa6c3f9562684d933180c07c t;
t.ssSTGetErrorDistributionOutStructure = (ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure)this.ssSTGetErrorDistributionOutStructure.Duplicate();
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
if (head == "geterrordistributionoutstructure") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GetErrorDistributionOutStructure")) variable.Value = ssSTGetErrorDistributionOutStructure; else variable.Optimized = true;
variable.SetFieldName("geterrordistributionoutstructure");
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
if (key == IdGetErrorDistributionOutStructure) {
return ssSTGetErrorDistributionOutStructure;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdGetErrorDistributionOutStructure.Key.AsGuid) {
return ssSTGetErrorDistributionOutStructure;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTGetErrorDistributionOutStructure.FillFromOther((IRecord) other.AttributeGet(IdGetErrorDistributionOutStructure));
}
} // RC_b75e1542aa6c3f9562684d933180c07c
/// <summary>
/// RecordList type <code>GetErrorDistributionOutStructureRecordList</code> that represents a record
///  list of <code>GetErrorDistributionOutStructure</code>
/// </summary>
public partial class RL_fda707884b7c5ce9466364bf65dd464a : GenericRecordList<RC_b75e1542aa6c3f9562684d933180c07c>, IEnumerable, IEnumerator {

protected override RC_b75e1542aa6c3f9562684d933180c07c GetElementDefaultValue() {
return new RC_b75e1542aa6c3f9562684d933180c07c();
}

public T[] ToArray<T>(Func<RC_b75e1542aa6c3f9562684d933180c07c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fda707884b7c5ce9466364bf65dd464a recordList, Func<RC_b75e1542aa6c3f9562684d933180c07c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fda707884b7c5ce9466364bf65dd464a(RC_b75e1542aa6c3f9562684d933180c07c[] array) {
  RL_fda707884b7c5ce9466364bf65dd464a result = new RL_fda707884b7c5ce9466364bf65dd464a();
result.InnerFromArray(array);
    return result;
}

public static RL_fda707884b7c5ce9466364bf65dd464a ToList<T>(T[] array, Func <T, RC_b75e1542aa6c3f9562684d933180c07c> converter) {
  RL_fda707884b7c5ce9466364bf65dd464a result = new RL_fda707884b7c5ce9466364bf65dd464a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fda707884b7c5ce9466364bf65dd464a FromRestList<T>(RestList<T> restList, Func <T, RC_b75e1542aa6c3f9562684d933180c07c> converter) {
  RL_fda707884b7c5ce9466364bf65dd464a result = new RL_fda707884b7c5ce9466364bf65dd464a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fda707884b7c5ce9466364bf65dd464a() : base() {
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
protected override OSList<RC_b75e1542aa6c3f9562684d933180c07c> NewList() {
return new RL_fda707884b7c5ce9466364bf65dd464a();
}


} // RL_fda707884b7c5ce9466364bf65dd464a
}

