namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (kQ06T9dHl0Sjh4nPmVzXsA)
///  <code>RC_d2ad758a70b2b40a58bde012aa28cd97</code> that represents <code>PI_ITEM_SMRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_SMRecord
public partial struct RC_d2ad758a70b2b40a58bde012aa28cd97 : ITypedRecord<RC_d2ad758a70b2b40a58bde012aa28cd97> {
internal static readonly GlobalObjectKey IdPI_ITEM_SM = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*inWt0rJwCrRYveASqijNlw");

public ST_e676179583470b305e615630acee7039Structure ssSTPI_ITEM_SM;


public static implicit operator ST_e676179583470b305e615630acee7039Structure( RC_d2ad758a70b2b40a58bde012aa28cd97 r) {
return r.ssSTPI_ITEM_SM;
}

public static implicit operator RC_d2ad758a70b2b40a58bde012aa28cd97 (ST_e676179583470b305e615630acee7039Structure r) {
RC_d2ad758a70b2b40a58bde012aa28cd97 res = new RC_d2ad758a70b2b40a58bde012aa28cd97 ();
res.ssSTPI_ITEM_SM = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_d2ad758a70b2b40a58bde012aa28cd97() {
OptimizedAttributes = null;
ssSTPI_ITEM_SM = new ST_e676179583470b305e615630acee7039Structure();
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
    ssSTPI_ITEM_SM.OptimizedAttributes = value[0];
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
ssSTPI_ITEM_SM.Read( r, ref index);
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
public void ReadIM(RC_d2ad758a70b2b40a58bde012aa28cd97 r) {
this = r;
}


public static bool operator == (RC_d2ad758a70b2b40a58bde012aa28cd97 a, RC_d2ad758a70b2b40a58bde012aa28cd97 b) {
if (a.ssSTPI_ITEM_SM != b.ssSTPI_ITEM_SM) return false;
return true;
}

public static bool operator != (RC_d2ad758a70b2b40a58bde012aa28cd97 a, RC_d2ad758a70b2b40a58bde012aa28cd97 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d2ad758a70b2b40a58bde012aa28cd97)) return false;
return (this == (RC_d2ad758a70b2b40a58bde012aa28cd97)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_ITEM_SM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_ITEM_SM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_ITEM_SM.InternalRecursiveSave();
}


public RC_d2ad758a70b2b40a58bde012aa28cd97 Duplicate() {
RC_d2ad758a70b2b40a58bde012aa28cd97 t;
t.ssSTPI_ITEM_SM = (ST_e676179583470b305e615630acee7039Structure)this.ssSTPI_ITEM_SM.Duplicate();
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
if (head == "pi_item_sm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_SM")) variable.Value = ssSTPI_ITEM_SM; else variable.Optimized = true;
variable.SetFieldName("pi_item_sm");
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
if (key == IdPI_ITEM_SM) {
return ssSTPI_ITEM_SM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_ITEM_SM.Key.AsGuid) {
return ssSTPI_ITEM_SM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_ITEM_SM.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM_SM));
}
} // RC_d2ad758a70b2b40a58bde012aa28cd97
/// <summary>
/// RecordList type <code>PI_ITEM_SMRecordList</code> that represents a record list of
///  <code>PI_ITEM_SM</code>
/// </summary>
public partial class RL_7013b9de3826d8992d4ff61b66ca2d10 : GenericRecordList<RC_d2ad758a70b2b40a58bde012aa28cd97>, IEnumerable, IEnumerator {

protected override RC_d2ad758a70b2b40a58bde012aa28cd97 GetElementDefaultValue() {
return new RC_d2ad758a70b2b40a58bde012aa28cd97();
}

public T[] ToArray<T>(Func<RC_d2ad758a70b2b40a58bde012aa28cd97, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7013b9de3826d8992d4ff61b66ca2d10 recordList, Func<RC_d2ad758a70b2b40a58bde012aa28cd97, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7013b9de3826d8992d4ff61b66ca2d10(RC_d2ad758a70b2b40a58bde012aa28cd97[] array) {
  RL_7013b9de3826d8992d4ff61b66ca2d10 result = new RL_7013b9de3826d8992d4ff61b66ca2d10();
result.InnerFromArray(array);
    return result;
}

public static RL_7013b9de3826d8992d4ff61b66ca2d10 ToList<T>(T[] array, Func <T, RC_d2ad758a70b2b40a58bde012aa28cd97> converter) {
  RL_7013b9de3826d8992d4ff61b66ca2d10 result = new RL_7013b9de3826d8992d4ff61b66ca2d10();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7013b9de3826d8992d4ff61b66ca2d10 FromRestList<T>(RestList<T> restList, Func <T, RC_d2ad758a70b2b40a58bde012aa28cd97> converter) {
  RL_7013b9de3826d8992d4ff61b66ca2d10 result = new RL_7013b9de3826d8992d4ff61b66ca2d10();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7013b9de3826d8992d4ff61b66ca2d10() : base() {
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
protected override OSList<RC_d2ad758a70b2b40a58bde012aa28cd97> NewList() {
return new RL_7013b9de3826d8992d4ff61b66ca2d10();
}


} // RL_7013b9de3826d8992d4ff61b66ca2d10
}

