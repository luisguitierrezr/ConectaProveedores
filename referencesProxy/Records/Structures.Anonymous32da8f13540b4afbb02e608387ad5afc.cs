namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (E4_aMgtU+0qwLmCDh61a_A)
///  <code>RC_0b4f56146907ab8c6c6acba005eb328c</code> that represents <code>TI_ITEM_OutRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TI_ITEM_OutRecord
public partial struct RC_0b4f56146907ab8c6c6acba005eb328c : ITypedRecord<RC_0b4f56146907ab8c6c6acba005eb328c> {
internal static readonly GlobalObjectKey IdTI_ITEM_Out = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FFZPCwdpjKtsasugBesyjA");

public ST_3b61de88b81d785d0616b445a04890fdStructure ssSTTI_ITEM_Out;


public static implicit operator ST_3b61de88b81d785d0616b445a04890fdStructure( RC_0b4f56146907ab8c6c6acba005eb328c r) {
return r.ssSTTI_ITEM_Out;
}

public static implicit operator RC_0b4f56146907ab8c6c6acba005eb328c (ST_3b61de88b81d785d0616b445a04890fdStructure r) {
RC_0b4f56146907ab8c6c6acba005eb328c res = new RC_0b4f56146907ab8c6c6acba005eb328c ();
res.ssSTTI_ITEM_Out = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0b4f56146907ab8c6c6acba005eb328c() {
OptimizedAttributes = null;
ssSTTI_ITEM_Out = new ST_3b61de88b81d785d0616b445a04890fdStructure();
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
    ssSTTI_ITEM_Out.OptimizedAttributes = value[0];
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
ssSTTI_ITEM_Out.Read( r, ref index);
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
public void ReadIM(RC_0b4f56146907ab8c6c6acba005eb328c r) {
this = r;
}


public static bool operator == (RC_0b4f56146907ab8c6c6acba005eb328c a, RC_0b4f56146907ab8c6c6acba005eb328c b) {
if (a.ssSTTI_ITEM_Out != b.ssSTTI_ITEM_Out) return false;
return true;
}

public static bool operator != (RC_0b4f56146907ab8c6c6acba005eb328c a, RC_0b4f56146907ab8c6c6acba005eb328c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0b4f56146907ab8c6c6acba005eb328c)) return false;
return (this == (RC_0b4f56146907ab8c6c6acba005eb328c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTI_ITEM_Out.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTI_ITEM_Out.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTI_ITEM_Out.InternalRecursiveSave();
}


public RC_0b4f56146907ab8c6c6acba005eb328c Duplicate() {
RC_0b4f56146907ab8c6c6acba005eb328c t;
t.ssSTTI_ITEM_Out = (ST_3b61de88b81d785d0616b445a04890fdStructure)this.ssSTTI_ITEM_Out.Duplicate();
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
if (head == "ti_item_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_ITEM_Out")) variable.Value = ssSTTI_ITEM_Out; else variable.Optimized = true;
variable.SetFieldName("ti_item_out");
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
if (key == IdTI_ITEM_Out) {
return ssSTTI_ITEM_Out;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTI_ITEM_Out.Key.AsGuid) {
return ssSTTI_ITEM_Out;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTI_ITEM_Out.FillFromOther((IRecord) other.AttributeGet(IdTI_ITEM_Out));
}
} // RC_0b4f56146907ab8c6c6acba005eb328c
/// <summary>
/// RecordList type <code>TI_ITEM_OutRecordList</code> that represents a record list of
///  <code>TI_ITEM_Out</code>
/// </summary>
public partial class RL_6d6c1077e3f64a13e2c27a81b025dccc : GenericRecordList<RC_0b4f56146907ab8c6c6acba005eb328c>, IEnumerable, IEnumerator {

protected override RC_0b4f56146907ab8c6c6acba005eb328c GetElementDefaultValue() {
return new RC_0b4f56146907ab8c6c6acba005eb328c();
}

public T[] ToArray<T>(Func<RC_0b4f56146907ab8c6c6acba005eb328c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6d6c1077e3f64a13e2c27a81b025dccc recordList, Func<RC_0b4f56146907ab8c6c6acba005eb328c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6d6c1077e3f64a13e2c27a81b025dccc(RC_0b4f56146907ab8c6c6acba005eb328c[] array) {
  RL_6d6c1077e3f64a13e2c27a81b025dccc result = new RL_6d6c1077e3f64a13e2c27a81b025dccc();
result.InnerFromArray(array);
    return result;
}

public static RL_6d6c1077e3f64a13e2c27a81b025dccc ToList<T>(T[] array, Func <T, RC_0b4f56146907ab8c6c6acba005eb328c> converter) {
  RL_6d6c1077e3f64a13e2c27a81b025dccc result = new RL_6d6c1077e3f64a13e2c27a81b025dccc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6d6c1077e3f64a13e2c27a81b025dccc FromRestList<T>(RestList<T> restList, Func <T, RC_0b4f56146907ab8c6c6acba005eb328c> converter) {
  RL_6d6c1077e3f64a13e2c27a81b025dccc result = new RL_6d6c1077e3f64a13e2c27a81b025dccc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6d6c1077e3f64a13e2c27a81b025dccc() : base() {
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
protected override OSList<RC_0b4f56146907ab8c6c6acba005eb328c> NewList() {
return new RL_6d6c1077e3f64a13e2c27a81b025dccc();
}


} // RL_6d6c1077e3f64a13e2c27a81b025dccc
}

