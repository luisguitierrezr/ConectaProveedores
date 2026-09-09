namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (vfiN654eAUOZQHNsPU_CIQ)
///  <code>RC_c9394e1c31772209550f46c7f600d6ee</code> that represents <code>ReassignmentsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ReassignmentsRecord
public partial struct RC_c9394e1c31772209550f46c7f600d6ee : ITypedRecord<RC_c9394e1c31772209550f46c7f600d6ee> {
internal static readonly GlobalObjectKey IdReassignments = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*HE45yXcxCSJVD0bH9gDW7g");

public EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord ssENReassignments;


public static implicit operator EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord( RC_c9394e1c31772209550f46c7f600d6ee r) {
return r.ssENReassignments;
}

public static implicit operator RC_c9394e1c31772209550f46c7f600d6ee (EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord r) {
RC_c9394e1c31772209550f46c7f600d6ee res = new RC_c9394e1c31772209550f46c7f600d6ee ();
res.ssENReassignments = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENReassignments.ChangedAttributes = value;
}
get {
    return ssENReassignments.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_c9394e1c31772209550f46c7f600d6ee() {
OptimizedAttributes = null;
ssENReassignments = new EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(17,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENReassignments.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENReassignments.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENReassignments.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENReassignments.Read( r, ref index);
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
public void ReadIM(RC_c9394e1c31772209550f46c7f600d6ee r) {
this = r;
}


public static bool operator == (RC_c9394e1c31772209550f46c7f600d6ee a, RC_c9394e1c31772209550f46c7f600d6ee b) {
if (a.ssENReassignments != b.ssENReassignments) return false;
return true;
}

public static bool operator != (RC_c9394e1c31772209550f46c7f600d6ee a, RC_c9394e1c31772209550f46c7f600d6ee b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c9394e1c31772209550f46c7f600d6ee)) return false;
return (this == (RC_c9394e1c31772209550f46c7f600d6ee)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENReassignments.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENReassignments.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENReassignments.InternalRecursiveSave();
}


public RC_c9394e1c31772209550f46c7f600d6ee Duplicate() {
RC_c9394e1c31772209550f46c7f600d6ee t;
t.ssENReassignments = (EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord)this.ssENReassignments.Duplicate();
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
if (head == "reassignments") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Reassignments")) variable.Value = ssENReassignments; else variable.Optimized = true;
variable.SetFieldName("reassignments");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENReassignments.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENReassignments.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdReassignments) {
return ssENReassignments;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdReassignments.Key.AsGuid) {
return ssENReassignments;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENReassignments.FillFromOther((IRecord) other.AttributeGet(IdReassignments));
}
} // RC_c9394e1c31772209550f46c7f600d6ee
/// <summary>
/// RecordList type <code>ReassignmentsRecordList</code> that represents a record list of
///  <code>Reassignments</code>
/// </summary>
public partial class RL_462b16c1ddedb19ce2dbad5e94ccb4ef : GenericRecordList<RC_c9394e1c31772209550f46c7f600d6ee>, IEnumerable, IEnumerator {

protected override RC_c9394e1c31772209550f46c7f600d6ee GetElementDefaultValue() {
return new RC_c9394e1c31772209550f46c7f600d6ee();
}

public T[] ToArray<T>(Func<RC_c9394e1c31772209550f46c7f600d6ee, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_462b16c1ddedb19ce2dbad5e94ccb4ef recordList, Func<RC_c9394e1c31772209550f46c7f600d6ee, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_462b16c1ddedb19ce2dbad5e94ccb4ef(RC_c9394e1c31772209550f46c7f600d6ee[] array) {
  RL_462b16c1ddedb19ce2dbad5e94ccb4ef result = new RL_462b16c1ddedb19ce2dbad5e94ccb4ef();
result.InnerFromArray(array);
    return result;
}

public static RL_462b16c1ddedb19ce2dbad5e94ccb4ef ToList<T>(T[] array, Func <T, RC_c9394e1c31772209550f46c7f600d6ee> converter) {
  RL_462b16c1ddedb19ce2dbad5e94ccb4ef result = new RL_462b16c1ddedb19ce2dbad5e94ccb4ef();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_462b16c1ddedb19ce2dbad5e94ccb4ef FromRestList<T>(RestList<T> restList, Func <T, RC_c9394e1c31772209550f46c7f600d6ee> converter) {
  RL_462b16c1ddedb19ce2dbad5e94ccb4ef result = new RL_462b16c1ddedb19ce2dbad5e94ccb4ef();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_462b16c1ddedb19ce2dbad5e94ccb4ef() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(17,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c9394e1c31772209550f46c7f600d6ee> NewList() {
return new RL_462b16c1ddedb19ce2dbad5e94ccb4ef();
}


} // RL_462b16c1ddedb19ce2dbad5e94ccb4ef
}

