namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (nDA5uiK_7k2OpJBRgUh2Hg)
///  <code>RC_e78705ffe9e8d9058346f81525af4b68</code> that represents <code>PI_ITEM_EMRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_EMRecord
public partial struct RC_e78705ffe9e8d9058346f81525af4b68 : ITypedRecord<RC_e78705ffe9e8d9058346f81525af4b68> {
internal static readonly GlobalObjectKey IdPI_ITEM_EM = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_wWH5+jpBdmDRvgVJa9LaA");

public ST_4e772ab2be79435889bcf86fc0455824Structure ssSTPI_ITEM_EM;


public static implicit operator ST_4e772ab2be79435889bcf86fc0455824Structure( RC_e78705ffe9e8d9058346f81525af4b68 r) {
return r.ssSTPI_ITEM_EM;
}

public static implicit operator RC_e78705ffe9e8d9058346f81525af4b68 (ST_4e772ab2be79435889bcf86fc0455824Structure r) {
RC_e78705ffe9e8d9058346f81525af4b68 res = new RC_e78705ffe9e8d9058346f81525af4b68 ();
res.ssSTPI_ITEM_EM = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e78705ffe9e8d9058346f81525af4b68() {
OptimizedAttributes = null;
ssSTPI_ITEM_EM = new ST_4e772ab2be79435889bcf86fc0455824Structure();
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
    ssSTPI_ITEM_EM.OptimizedAttributes = value[0];
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
ssSTPI_ITEM_EM.Read( r, ref index);
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
public void ReadIM(RC_e78705ffe9e8d9058346f81525af4b68 r) {
this = r;
}


public static bool operator == (RC_e78705ffe9e8d9058346f81525af4b68 a, RC_e78705ffe9e8d9058346f81525af4b68 b) {
if (a.ssSTPI_ITEM_EM != b.ssSTPI_ITEM_EM) return false;
return true;
}

public static bool operator != (RC_e78705ffe9e8d9058346f81525af4b68 a, RC_e78705ffe9e8d9058346f81525af4b68 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e78705ffe9e8d9058346f81525af4b68)) return false;
return (this == (RC_e78705ffe9e8d9058346f81525af4b68)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_ITEM_EM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_ITEM_EM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_ITEM_EM.InternalRecursiveSave();
}


public RC_e78705ffe9e8d9058346f81525af4b68 Duplicate() {
RC_e78705ffe9e8d9058346f81525af4b68 t;
t.ssSTPI_ITEM_EM = (ST_4e772ab2be79435889bcf86fc0455824Structure)this.ssSTPI_ITEM_EM.Duplicate();
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
if (head == "pi_item_em") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_EM")) variable.Value = ssSTPI_ITEM_EM; else variable.Optimized = true;
variable.SetFieldName("pi_item_em");
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
if (key == IdPI_ITEM_EM) {
return ssSTPI_ITEM_EM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_ITEM_EM.Key.AsGuid) {
return ssSTPI_ITEM_EM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_ITEM_EM.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM_EM));
}
} // RC_e78705ffe9e8d9058346f81525af4b68
/// <summary>
/// RecordList type <code>PI_ITEM_EMRecordList</code> that represents a record list of
///  <code>PI_ITEM_EM</code>
/// </summary>
public partial class RL_4846a9f9d59c067cf44781ff10ae4e1d : GenericRecordList<RC_e78705ffe9e8d9058346f81525af4b68>, IEnumerable, IEnumerator {

protected override RC_e78705ffe9e8d9058346f81525af4b68 GetElementDefaultValue() {
return new RC_e78705ffe9e8d9058346f81525af4b68();
}

public T[] ToArray<T>(Func<RC_e78705ffe9e8d9058346f81525af4b68, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4846a9f9d59c067cf44781ff10ae4e1d recordList, Func<RC_e78705ffe9e8d9058346f81525af4b68, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4846a9f9d59c067cf44781ff10ae4e1d(RC_e78705ffe9e8d9058346f81525af4b68[] array) {
  RL_4846a9f9d59c067cf44781ff10ae4e1d result = new RL_4846a9f9d59c067cf44781ff10ae4e1d();
result.InnerFromArray(array);
    return result;
}

public static RL_4846a9f9d59c067cf44781ff10ae4e1d ToList<T>(T[] array, Func <T, RC_e78705ffe9e8d9058346f81525af4b68> converter) {
  RL_4846a9f9d59c067cf44781ff10ae4e1d result = new RL_4846a9f9d59c067cf44781ff10ae4e1d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4846a9f9d59c067cf44781ff10ae4e1d FromRestList<T>(RestList<T> restList, Func <T, RC_e78705ffe9e8d9058346f81525af4b68> converter) {
  RL_4846a9f9d59c067cf44781ff10ae4e1d result = new RL_4846a9f9d59c067cf44781ff10ae4e1d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4846a9f9d59c067cf44781ff10ae4e1d() : base() {
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
protected override OSList<RC_e78705ffe9e8d9058346f81525af4b68> NewList() {
return new RL_4846a9f9d59c067cf44781ff10ae4e1d();
}


} // RL_4846a9f9d59c067cf44781ff10ae4e1d
}

