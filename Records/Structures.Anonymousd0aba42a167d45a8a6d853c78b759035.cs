namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (KqSr0H0WqEWm2FPHi3WQNQ)
///  <code>RC_f53eb6300d410e7f0eaa48de8ddcca4e</code> that represents <code>PI_HEADER_RMRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_HEADER_RMRecord
public partial struct RC_f53eb6300d410e7f0eaa48de8ddcca4e : ITypedRecord<RC_f53eb6300d410e7f0eaa48de8ddcca4e> {
internal static readonly GlobalObjectKey IdPI_HEADER_RM = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MLY+9UENfw4OqkjejdzKTg");

public ST_cab398c7a09085084636430b80f5aa0dStructure ssSTPI_HEADER_RM;


public static implicit operator ST_cab398c7a09085084636430b80f5aa0dStructure( RC_f53eb6300d410e7f0eaa48de8ddcca4e r) {
return r.ssSTPI_HEADER_RM;
}

public static implicit operator RC_f53eb6300d410e7f0eaa48de8ddcca4e (ST_cab398c7a09085084636430b80f5aa0dStructure r) {
RC_f53eb6300d410e7f0eaa48de8ddcca4e res = new RC_f53eb6300d410e7f0eaa48de8ddcca4e ();
res.ssSTPI_HEADER_RM = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f53eb6300d410e7f0eaa48de8ddcca4e() {
OptimizedAttributes = null;
ssSTPI_HEADER_RM = new ST_cab398c7a09085084636430b80f5aa0dStructure();
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
    ssSTPI_HEADER_RM.OptimizedAttributes = value[0];
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
ssSTPI_HEADER_RM.Read( r, ref index);
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
public void ReadIM(RC_f53eb6300d410e7f0eaa48de8ddcca4e r) {
this = r;
}


public static bool operator == (RC_f53eb6300d410e7f0eaa48de8ddcca4e a, RC_f53eb6300d410e7f0eaa48de8ddcca4e b) {
if (a.ssSTPI_HEADER_RM != b.ssSTPI_HEADER_RM) return false;
return true;
}

public static bool operator != (RC_f53eb6300d410e7f0eaa48de8ddcca4e a, RC_f53eb6300d410e7f0eaa48de8ddcca4e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f53eb6300d410e7f0eaa48de8ddcca4e)) return false;
return (this == (RC_f53eb6300d410e7f0eaa48de8ddcca4e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_HEADER_RM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_HEADER_RM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_HEADER_RM.InternalRecursiveSave();
}


public RC_f53eb6300d410e7f0eaa48de8ddcca4e Duplicate() {
RC_f53eb6300d410e7f0eaa48de8ddcca4e t;
t.ssSTPI_HEADER_RM = (ST_cab398c7a09085084636430b80f5aa0dStructure)this.ssSTPI_HEADER_RM.Duplicate();
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
if (head == "pi_header_rm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_HEADER_RM")) variable.Value = ssSTPI_HEADER_RM; else variable.Optimized = true;
variable.SetFieldName("pi_header_rm");
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
if (key == IdPI_HEADER_RM) {
return ssSTPI_HEADER_RM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_HEADER_RM.Key.AsGuid) {
return ssSTPI_HEADER_RM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_HEADER_RM.FillFromOther((IRecord) other.AttributeGet(IdPI_HEADER_RM));
}
} // RC_f53eb6300d410e7f0eaa48de8ddcca4e
/// <summary>
/// RecordList type <code>PI_HEADER_RMRecordList</code> that represents a record list of
///  <code>PI_HEADER_RM</code>
/// </summary>
public partial class RL_b9e40d1968566ad18db99a755be65280 : GenericRecordList<RC_f53eb6300d410e7f0eaa48de8ddcca4e>, IEnumerable, IEnumerator {

protected override RC_f53eb6300d410e7f0eaa48de8ddcca4e GetElementDefaultValue() {
return new RC_f53eb6300d410e7f0eaa48de8ddcca4e();
}

public T[] ToArray<T>(Func<RC_f53eb6300d410e7f0eaa48de8ddcca4e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b9e40d1968566ad18db99a755be65280 recordList, Func<RC_f53eb6300d410e7f0eaa48de8ddcca4e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b9e40d1968566ad18db99a755be65280(RC_f53eb6300d410e7f0eaa48de8ddcca4e[] array) {
  RL_b9e40d1968566ad18db99a755be65280 result = new RL_b9e40d1968566ad18db99a755be65280();
result.InnerFromArray(array);
    return result;
}

public static RL_b9e40d1968566ad18db99a755be65280 ToList<T>(T[] array, Func <T, RC_f53eb6300d410e7f0eaa48de8ddcca4e> converter) {
  RL_b9e40d1968566ad18db99a755be65280 result = new RL_b9e40d1968566ad18db99a755be65280();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b9e40d1968566ad18db99a755be65280 FromRestList<T>(RestList<T> restList, Func <T, RC_f53eb6300d410e7f0eaa48de8ddcca4e> converter) {
  RL_b9e40d1968566ad18db99a755be65280 result = new RL_b9e40d1968566ad18db99a755be65280();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b9e40d1968566ad18db99a755be65280() : base() {
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
protected override OSList<RC_f53eb6300d410e7f0eaa48de8ddcca4e> NewList() {
return new RL_b9e40d1968566ad18db99a755be65280();
}


} // RL_b9e40d1968566ad18db99a755be65280
}

