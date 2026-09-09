namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (_G7oOitBQkS5JM+qx+tcmA)
///  <code>RC_11a1c2c6093e72d7b098f7d9d4ea49b0</code> that represents <code>AuditStruc4ListRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: AuditStruc4ListRecord
public partial struct RC_11a1c2c6093e72d7b098f7d9d4ea49b0 : ITypedRecord<RC_11a1c2c6093e72d7b098f7d9d4ea49b0> {
internal static readonly GlobalObjectKey IdAuditStruc4List = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xsKhET4J13KwmPfZ1OpJsA");

public ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure ssSTAuditStruc4List;


public static implicit operator ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure( RC_11a1c2c6093e72d7b098f7d9d4ea49b0 r) {
return r.ssSTAuditStruc4List;
}

public static implicit operator RC_11a1c2c6093e72d7b098f7d9d4ea49b0 (ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure r) {
RC_11a1c2c6093e72d7b098f7d9d4ea49b0 res = new RC_11a1c2c6093e72d7b098f7d9d4ea49b0 ();
res.ssSTAuditStruc4List = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_11a1c2c6093e72d7b098f7d9d4ea49b0() {
OptimizedAttributes = null;
ssSTAuditStruc4List = new ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure();
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
    ssSTAuditStruc4List.OptimizedAttributes = value[0];
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
ssSTAuditStruc4List.Read( r, ref index);
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
public void ReadIM(RC_11a1c2c6093e72d7b098f7d9d4ea49b0 r) {
this = r;
}


public static bool operator == (RC_11a1c2c6093e72d7b098f7d9d4ea49b0 a, RC_11a1c2c6093e72d7b098f7d9d4ea49b0 b) {
if (a.ssSTAuditStruc4List != b.ssSTAuditStruc4List) return false;
return true;
}

public static bool operator != (RC_11a1c2c6093e72d7b098f7d9d4ea49b0 a, RC_11a1c2c6093e72d7b098f7d9d4ea49b0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_11a1c2c6093e72d7b098f7d9d4ea49b0)) return false;
return (this == (RC_11a1c2c6093e72d7b098f7d9d4ea49b0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTAuditStruc4List.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTAuditStruc4List.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTAuditStruc4List.InternalRecursiveSave();
}


public RC_11a1c2c6093e72d7b098f7d9d4ea49b0 Duplicate() {
RC_11a1c2c6093e72d7b098f7d9d4ea49b0 t;
t.ssSTAuditStruc4List = (ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure)this.ssSTAuditStruc4List.Duplicate();
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
if (head == "auditstruc4list") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AuditStruc4List")) variable.Value = ssSTAuditStruc4List; else variable.Optimized = true;
variable.SetFieldName("auditstruc4list");
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
if (key == IdAuditStruc4List) {
return ssSTAuditStruc4List;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAuditStruc4List.Key.AsGuid) {
return ssSTAuditStruc4List;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTAuditStruc4List.FillFromOther((IRecord) other.AttributeGet(IdAuditStruc4List));
}
} // RC_11a1c2c6093e72d7b098f7d9d4ea49b0
/// <summary>
/// RecordList type <code>AuditStruc4ListRecordList</code> that represents a record list of
///  <code>AuditStruc4List</code>
/// </summary>
public partial class RL_938b58e1eb904ca6e2a26c8a12b76f01 : GenericRecordList<RC_11a1c2c6093e72d7b098f7d9d4ea49b0>, IEnumerable, IEnumerator {

protected override RC_11a1c2c6093e72d7b098f7d9d4ea49b0 GetElementDefaultValue() {
return new RC_11a1c2c6093e72d7b098f7d9d4ea49b0();
}

public T[] ToArray<T>(Func<RC_11a1c2c6093e72d7b098f7d9d4ea49b0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_938b58e1eb904ca6e2a26c8a12b76f01 recordList, Func<RC_11a1c2c6093e72d7b098f7d9d4ea49b0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_938b58e1eb904ca6e2a26c8a12b76f01(RC_11a1c2c6093e72d7b098f7d9d4ea49b0[] array) {
  RL_938b58e1eb904ca6e2a26c8a12b76f01 result = new RL_938b58e1eb904ca6e2a26c8a12b76f01();
result.InnerFromArray(array);
    return result;
}

public static RL_938b58e1eb904ca6e2a26c8a12b76f01 ToList<T>(T[] array, Func <T, RC_11a1c2c6093e72d7b098f7d9d4ea49b0> converter) {
  RL_938b58e1eb904ca6e2a26c8a12b76f01 result = new RL_938b58e1eb904ca6e2a26c8a12b76f01();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_938b58e1eb904ca6e2a26c8a12b76f01 FromRestList<T>(RestList<T> restList, Func <T, RC_11a1c2c6093e72d7b098f7d9d4ea49b0> converter) {
  RL_938b58e1eb904ca6e2a26c8a12b76f01 result = new RL_938b58e1eb904ca6e2a26c8a12b76f01();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_938b58e1eb904ca6e2a26c8a12b76f01() : base() {
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
protected override OSList<RC_11a1c2c6093e72d7b098f7d9d4ea49b0> NewList() {
return new RL_938b58e1eb904ca6e2a26c8a12b76f01();
}


} // RL_938b58e1eb904ca6e2a26c8a12b76f01
}

