namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (4Bt2ELHrXUaNv3LVSZXPug)
///  <code>RC_8f0936c3c24768761df4a411edbf9176</code> that represents <code>PI_ITEM_EM3Record</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_EM3Record
public partial struct RC_8f0936c3c24768761df4a411edbf9176 : ITypedRecord<RC_8f0936c3c24768761df4a411edbf9176> {
internal static readonly GlobalObjectKey IdPI_ITEM_EM3 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wzYJj0fCdmgd9KQR7b+Rdg");

public ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure ssSTPI_ITEM_EM3;


public static implicit operator ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure( RC_8f0936c3c24768761df4a411edbf9176 r) {
return r.ssSTPI_ITEM_EM3;
}

public static implicit operator RC_8f0936c3c24768761df4a411edbf9176 (ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure r) {
RC_8f0936c3c24768761df4a411edbf9176 res = new RC_8f0936c3c24768761df4a411edbf9176 ();
res.ssSTPI_ITEM_EM3 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_8f0936c3c24768761df4a411edbf9176() {
OptimizedAttributes = null;
ssSTPI_ITEM_EM3 = new ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure();
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
    ssSTPI_ITEM_EM3.OptimizedAttributes = value[0];
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
ssSTPI_ITEM_EM3.Read( r, ref index);
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
public void ReadIM(RC_8f0936c3c24768761df4a411edbf9176 r) {
this = r;
}


public static bool operator == (RC_8f0936c3c24768761df4a411edbf9176 a, RC_8f0936c3c24768761df4a411edbf9176 b) {
if (a.ssSTPI_ITEM_EM3 != b.ssSTPI_ITEM_EM3) return false;
return true;
}

public static bool operator != (RC_8f0936c3c24768761df4a411edbf9176 a, RC_8f0936c3c24768761df4a411edbf9176 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8f0936c3c24768761df4a411edbf9176)) return false;
return (this == (RC_8f0936c3c24768761df4a411edbf9176)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_ITEM_EM3.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_ITEM_EM3.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_ITEM_EM3.InternalRecursiveSave();
}


public RC_8f0936c3c24768761df4a411edbf9176 Duplicate() {
RC_8f0936c3c24768761df4a411edbf9176 t;
t.ssSTPI_ITEM_EM3 = (ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure)this.ssSTPI_ITEM_EM3.Duplicate();
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
if (head == "pi_item_em3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_EM3")) variable.Value = ssSTPI_ITEM_EM3; else variable.Optimized = true;
variable.SetFieldName("pi_item_em3");
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
if (key == IdPI_ITEM_EM3) {
return ssSTPI_ITEM_EM3;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_ITEM_EM3.Key.AsGuid) {
return ssSTPI_ITEM_EM3;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_ITEM_EM3.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM_EM3));
}
} // RC_8f0936c3c24768761df4a411edbf9176
/// <summary>
/// RecordList type <code>PI_ITEM_EM3RecordList</code> that represents a record list of
///  <code>PI_ITEM_EM3</code>
/// </summary>
public partial class RL_38d4fdd27de289f024ae5080143d8cf9 : GenericRecordList<RC_8f0936c3c24768761df4a411edbf9176>, IEnumerable, IEnumerator {

protected override RC_8f0936c3c24768761df4a411edbf9176 GetElementDefaultValue() {
return new RC_8f0936c3c24768761df4a411edbf9176();
}

public T[] ToArray<T>(Func<RC_8f0936c3c24768761df4a411edbf9176, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_38d4fdd27de289f024ae5080143d8cf9 recordList, Func<RC_8f0936c3c24768761df4a411edbf9176, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_38d4fdd27de289f024ae5080143d8cf9(RC_8f0936c3c24768761df4a411edbf9176[] array) {
  RL_38d4fdd27de289f024ae5080143d8cf9 result = new RL_38d4fdd27de289f024ae5080143d8cf9();
result.InnerFromArray(array);
    return result;
}

public static RL_38d4fdd27de289f024ae5080143d8cf9 ToList<T>(T[] array, Func <T, RC_8f0936c3c24768761df4a411edbf9176> converter) {
  RL_38d4fdd27de289f024ae5080143d8cf9 result = new RL_38d4fdd27de289f024ae5080143d8cf9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_38d4fdd27de289f024ae5080143d8cf9 FromRestList<T>(RestList<T> restList, Func <T, RC_8f0936c3c24768761df4a411edbf9176> converter) {
  RL_38d4fdd27de289f024ae5080143d8cf9 result = new RL_38d4fdd27de289f024ae5080143d8cf9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_38d4fdd27de289f024ae5080143d8cf9() : base() {
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
protected override OSList<RC_8f0936c3c24768761df4a411edbf9176> NewList() {
return new RL_38d4fdd27de289f024ae5080143d8cf9();
}


} // RL_38d4fdd27de289f024ae5080143d8cf9
}

