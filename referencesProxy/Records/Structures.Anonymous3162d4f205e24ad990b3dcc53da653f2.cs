namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (8tRiMeIF2UqQs9zFPaZT8g)
///  <code>RC_e16f126ae5f7407d32d4a429fb32ca9a</code> that represents <code>InsuranceTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InsuranceTypeRecord
public partial struct RC_e16f126ae5f7407d32d4a429fb32ca9a : ITypedRecord<RC_e16f126ae5f7407d32d4a429fb32ca9a> {
internal static readonly GlobalObjectKey IdInsuranceType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ahJv4fflfUAy1KQp+zLKmg");

public EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord ssENInsuranceType;


public static implicit operator EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord( RC_e16f126ae5f7407d32d4a429fb32ca9a r) {
return r.ssENInsuranceType;
}

public static implicit operator RC_e16f126ae5f7407d32d4a429fb32ca9a (EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord r) {
RC_e16f126ae5f7407d32d4a429fb32ca9a res = new RC_e16f126ae5f7407d32d4a429fb32ca9a ();
res.ssENInsuranceType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInsuranceType.ChangedAttributes = value;
}
get {
    return ssENInsuranceType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_e16f126ae5f7407d32d4a429fb32ca9a() {
OptimizedAttributes = null;
ssENInsuranceType = new EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInsuranceType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInsuranceType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInsuranceType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInsuranceType.Read( r, ref index);
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
public void ReadIM(RC_e16f126ae5f7407d32d4a429fb32ca9a r) {
this = r;
}


public static bool operator == (RC_e16f126ae5f7407d32d4a429fb32ca9a a, RC_e16f126ae5f7407d32d4a429fb32ca9a b) {
if (a.ssENInsuranceType != b.ssENInsuranceType) return false;
return true;
}

public static bool operator != (RC_e16f126ae5f7407d32d4a429fb32ca9a a, RC_e16f126ae5f7407d32d4a429fb32ca9a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e16f126ae5f7407d32d4a429fb32ca9a)) return false;
return (this == (RC_e16f126ae5f7407d32d4a429fb32ca9a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInsuranceType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInsuranceType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInsuranceType.InternalRecursiveSave();
}


public RC_e16f126ae5f7407d32d4a429fb32ca9a Duplicate() {
RC_e16f126ae5f7407d32d4a429fb32ca9a t;
t.ssENInsuranceType = (EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord)this.ssENInsuranceType.Duplicate();
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
if (head == "insurancetype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InsuranceType")) variable.Value = ssENInsuranceType; else variable.Optimized = true;
variable.SetFieldName("insurancetype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInsuranceType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInsuranceType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInsuranceType) {
return ssENInsuranceType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInsuranceType.Key.AsGuid) {
return ssENInsuranceType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInsuranceType.FillFromOther((IRecord) other.AttributeGet(IdInsuranceType));
}
} // RC_e16f126ae5f7407d32d4a429fb32ca9a
/// <summary>
/// RecordList type <code>InsuranceTypeRecordList</code> that represents a record list of
///  <code>InsuranceType</code>
/// </summary>
public partial class RL_32b3fec96f8ddbf444444f34b158e188 : GenericRecordList<RC_e16f126ae5f7407d32d4a429fb32ca9a>, IEnumerable, IEnumerator {

protected override RC_e16f126ae5f7407d32d4a429fb32ca9a GetElementDefaultValue() {
return new RC_e16f126ae5f7407d32d4a429fb32ca9a();
}

public T[] ToArray<T>(Func<RC_e16f126ae5f7407d32d4a429fb32ca9a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_32b3fec96f8ddbf444444f34b158e188 recordList, Func<RC_e16f126ae5f7407d32d4a429fb32ca9a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_32b3fec96f8ddbf444444f34b158e188(RC_e16f126ae5f7407d32d4a429fb32ca9a[] array) {
  RL_32b3fec96f8ddbf444444f34b158e188 result = new RL_32b3fec96f8ddbf444444f34b158e188();
result.InnerFromArray(array);
    return result;
}

public static RL_32b3fec96f8ddbf444444f34b158e188 ToList<T>(T[] array, Func <T, RC_e16f126ae5f7407d32d4a429fb32ca9a> converter) {
  RL_32b3fec96f8ddbf444444f34b158e188 result = new RL_32b3fec96f8ddbf444444f34b158e188();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_32b3fec96f8ddbf444444f34b158e188 FromRestList<T>(RestList<T> restList, Func <T, RC_e16f126ae5f7407d32d4a429fb32ca9a> converter) {
  RL_32b3fec96f8ddbf444444f34b158e188 result = new RL_32b3fec96f8ddbf444444f34b158e188();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_32b3fec96f8ddbf444444f34b158e188() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e16f126ae5f7407d32d4a429fb32ca9a> NewList() {
return new RL_32b3fec96f8ddbf444444f34b158e188();
}


} // RL_32b3fec96f8ddbf444444f34b158e188
}

