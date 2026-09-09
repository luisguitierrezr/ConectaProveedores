namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (9AX9zVvHrUiasj_eWUzHkQ)
///  <code>RC_23f04252aed9962b8ebdb251db000b96</code> that represent
/// s <code>SeriesStylingMarkerRecord</code> <p>Description: </p>
/// </summary>
// Name: SeriesStylingMarkerRecord
public partial struct RC_23f04252aed9962b8ebdb251db000b96 : ITypedRecord<RC_23f04252aed9962b8ebdb251db000b96> {
internal static readonly GlobalObjectKey IdSeriesStylingMarker = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*UkLwI9muK5aOvbJR2wALlg");

public ST_73b5287c34f36a04fe003585368d6e1bStructure ssSTSeriesStylingMarker;


public static implicit operator ST_73b5287c34f36a04fe003585368d6e1bStructure( RC_23f04252aed9962b8ebdb251db000b96 r) {
return r.ssSTSeriesStylingMarker;
}

public static implicit operator RC_23f04252aed9962b8ebdb251db000b96 (ST_73b5287c34f36a04fe003585368d6e1bStructure r) {
RC_23f04252aed9962b8ebdb251db000b96 res = new RC_23f04252aed9962b8ebdb251db000b96 ();
res.ssSTSeriesStylingMarker = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_23f04252aed9962b8ebdb251db000b96() {
OptimizedAttributes = null;
ssSTSeriesStylingMarker = new ST_73b5287c34f36a04fe003585368d6e1bStructure();
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
    ssSTSeriesStylingMarker.OptimizedAttributes = value[0];
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
ssSTSeriesStylingMarker.Read( r, ref index);
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
public void ReadIM(RC_23f04252aed9962b8ebdb251db000b96 r) {
this = r;
}


public static bool operator == (RC_23f04252aed9962b8ebdb251db000b96 a, RC_23f04252aed9962b8ebdb251db000b96 b) {
if (a.ssSTSeriesStylingMarker != b.ssSTSeriesStylingMarker) return false;
return true;
}

public static bool operator != (RC_23f04252aed9962b8ebdb251db000b96 a, RC_23f04252aed9962b8ebdb251db000b96 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_23f04252aed9962b8ebdb251db000b96)) return false;
return (this == (RC_23f04252aed9962b8ebdb251db000b96)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTSeriesStylingMarker.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTSeriesStylingMarker.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTSeriesStylingMarker.InternalRecursiveSave();
}


public RC_23f04252aed9962b8ebdb251db000b96 Duplicate() {
RC_23f04252aed9962b8ebdb251db000b96 t;
t.ssSTSeriesStylingMarker = (ST_73b5287c34f36a04fe003585368d6e1bStructure)this.ssSTSeriesStylingMarker.Duplicate();
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
if (head == "seriesstylingmarker") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SeriesStylingMarker")) variable.Value = ssSTSeriesStylingMarker; else variable.Optimized = true;
variable.SetFieldName("seriesstylingmarker");
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
if (key == IdSeriesStylingMarker) {
return ssSTSeriesStylingMarker;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSeriesStylingMarker.Key.AsGuid) {
return ssSTSeriesStylingMarker;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTSeriesStylingMarker.FillFromOther((IRecord) other.AttributeGet(IdSeriesStylingMarker));
}
} // RC_23f04252aed9962b8ebdb251db000b96
/// <summary>
/// RecordList type <code>SeriesStylingMarkerRecordList</code> that represents a record list of
///  <code>SeriesStylingMarker</code>
/// </summary>
public partial class RL_96c910d11089048c052793c7ed737383 : GenericRecordList<RC_23f04252aed9962b8ebdb251db000b96>, IEnumerable, IEnumerator {

protected override RC_23f04252aed9962b8ebdb251db000b96 GetElementDefaultValue() {
return new RC_23f04252aed9962b8ebdb251db000b96();
}

public T[] ToArray<T>(Func<RC_23f04252aed9962b8ebdb251db000b96, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_96c910d11089048c052793c7ed737383 recordList, Func<RC_23f04252aed9962b8ebdb251db000b96, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_96c910d11089048c052793c7ed737383(RC_23f04252aed9962b8ebdb251db000b96[] array) {
  RL_96c910d11089048c052793c7ed737383 result = new RL_96c910d11089048c052793c7ed737383();
result.InnerFromArray(array);
    return result;
}

public static RL_96c910d11089048c052793c7ed737383 ToList<T>(T[] array, Func <T, RC_23f04252aed9962b8ebdb251db000b96> converter) {
  RL_96c910d11089048c052793c7ed737383 result = new RL_96c910d11089048c052793c7ed737383();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_96c910d11089048c052793c7ed737383 FromRestList<T>(RestList<T> restList, Func <T, RC_23f04252aed9962b8ebdb251db000b96> converter) {
  RL_96c910d11089048c052793c7ed737383 result = new RL_96c910d11089048c052793c7ed737383();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_96c910d11089048c052793c7ed737383() : base() {
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
protected override OSList<RC_23f04252aed9962b8ebdb251db000b96> NewList() {
return new RL_96c910d11089048c052793c7ed737383();
}


} // RL_96c910d11089048c052793c7ed737383
}

