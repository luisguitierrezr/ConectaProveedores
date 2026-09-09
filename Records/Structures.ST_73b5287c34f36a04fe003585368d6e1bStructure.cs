namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] SeriesStylingMarker (B+0Bp8906EKNHT7OJuhioA)
///  <code>ST_73b5287c34f36a04fe003585368d6e1bStructure</code> that represent
/// s <code>SeriesStylingMarker</code> <p>Description: Define the styles for the marker inside a
///  specific serie of the chart.</p>
/// </summary>
// Name: SeriesStylingMarker
public partial struct ST_73b5287c34f36a04fe003585368d6e1bStructure : ITypedRecord<ST_73b5287c34f36a04fe003585368d6e1bStructure> {
internal static readonly GlobalObjectKey IdHideMarker = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*qwOvvOb0TE617c4bFUBTKg");
internal static readonly GlobalObjectKey IdFillColor = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*+qivWcAaLUuzjGon+ecKFw");
internal static readonly GlobalObjectKey IdBorderColor = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*JslFcISVpEK5RsBGUSm7jg");
internal static readonly GlobalObjectKey IdBorderWidth = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*zJL+1x09+kmseFnCzXd5wg");
internal static readonly GlobalObjectKey IdRadius = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*q_jZ832uI0mcwfUsSHNyKw");
internal static readonly GlobalObjectKey IdMarkerSymbol = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*95oichKNT0Gn_kgBn3x6Eg");

public bool ssHideMarker;

public string ssFillColor;

public string ssBorderColor;

public string ssBorderWidth;

public int ssRadius;

public string ssMarkerSymbol;


public BitArray OptimizedAttributes;

public ST_73b5287c34f36a04fe003585368d6e1bStructure() {
OptimizedAttributes = null;
ssHideMarker = false;
ssFillColor = "";
ssBorderColor = "";
ssBorderWidth = "";
ssRadius = 4;
ssMarkerSymbol = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssHideMarker = r.ReadBoolean(index++, "SeriesStylingMarker.HideMarker", false);
ssFillColor = r.ReadText(index++, "SeriesStylingMarker.FillColor", "");
ssBorderColor = r.ReadText(index++, "SeriesStylingMarker.BorderColor", "");
ssBorderWidth = r.ReadText(index++, "SeriesStylingMarker.BorderWidth", "");
ssRadius = r.ReadInteger(index++, "SeriesStylingMarker.Radius", 0);
ssMarkerSymbol = r.ReadText(index++, "SeriesStylingMarker.MarkerSymbol", "");
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
public void ReadIM(ST_73b5287c34f36a04fe003585368d6e1bStructure r) {
this = r;
}


public static bool operator == (ST_73b5287c34f36a04fe003585368d6e1bStructure a, ST_73b5287c34f36a04fe003585368d6e1bStructure b) {
if (a.ssHideMarker != b.ssHideMarker) return false;
if (a.ssFillColor != b.ssFillColor) return false;
if (a.ssBorderColor != b.ssBorderColor) return false;
if (a.ssBorderWidth != b.ssBorderWidth) return false;
if (a.ssRadius != b.ssRadius) return false;
if (a.ssMarkerSymbol != b.ssMarkerSymbol) return false;
return true;
}

public static bool operator != (ST_73b5287c34f36a04fe003585368d6e1bStructure a, ST_73b5287c34f36a04fe003585368d6e1bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_73b5287c34f36a04fe003585368d6e1bStructure)) return false;
return (this == (ST_73b5287c34f36a04fe003585368d6e1bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssHideMarker.GetHashCode()
 ^ ssFillColor.GetHashCode()
 ^ ssBorderColor.GetHashCode()
 ^ ssBorderWidth.GetHashCode()
 ^ ssRadius.GetHashCode()
 ^ ssMarkerSymbol.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_73b5287c34f36a04fe003585368d6e1bStructure Duplicate() {
ST_73b5287c34f36a04fe003585368d6e1bStructure t;
t.ssHideMarker = this.ssHideMarker;
t.ssFillColor = this.ssFillColor;
t.ssBorderColor = this.ssBorderColor;
t.ssBorderWidth = this.ssBorderWidth;
t.ssRadius = this.ssRadius;
t.ssMarkerSymbol = this.ssMarkerSymbol;
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
if (head == "hidemarker") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HideMarker")) variable.Value = ssHideMarker; else variable.Optimized = true;
} else if (head == "fillcolor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FillColor")) variable.Value = ssFillColor; else variable.Optimized = true;
} else if (head == "bordercolor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BorderColor")) variable.Value = ssBorderColor; else variable.Optimized = true;
} else if (head == "borderwidth") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BorderWidth")) variable.Value = ssBorderWidth; else variable.Optimized = true;
} else if (head == "radius") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Radius")) variable.Value = ssRadius; else variable.Optimized = true;
} else if (head == "markersymbol") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MarkerSymbol")) variable.Value = ssMarkerSymbol; else variable.Optimized = true;
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
if (key == IdHideMarker) {
return ssHideMarker;
}
if (key == IdFillColor) {
return ssFillColor;
}
if (key == IdBorderColor) {
return ssBorderColor;
}
if (key == IdBorderWidth) {
return ssBorderWidth;
}
if (key == IdRadius) {
return ssRadius;
}
if (key == IdMarkerSymbol) {
return ssMarkerSymbol;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdHideMarker.Key.AsGuid) {
return ssHideMarker;
}
if (attributeKey == IdFillColor.Key.AsGuid) {
return ssFillColor;
}
if (attributeKey == IdBorderColor.Key.AsGuid) {
return ssBorderColor;
}
if (attributeKey == IdBorderWidth.Key.AsGuid) {
return ssBorderWidth;
}
if (attributeKey == IdRadius.Key.AsGuid) {
return ssRadius;
}
if (attributeKey == IdMarkerSymbol.Key.AsGuid) {
return ssMarkerSymbol;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssHideMarker = (bool) other.AttributeGet(IdHideMarker);
ssFillColor = (string) other.AttributeGet(IdFillColor);
ssBorderColor = (string) other.AttributeGet(IdBorderColor);
ssBorderWidth = (string) other.AttributeGet(IdBorderWidth);
ssRadius = (int) other.AttributeGet(IdRadius);
ssMarkerSymbol = (string) other.AttributeGet(IdMarkerSymbol);
}
} // ST_73b5287c34f36a04fe003585368d6e1bStructure
/// <summary>
/// RecordList type <code>SeriesStylingMarkerList</code> that represents a record list of
///  <code>SeriesStylingMarker</code>
/// </summary>
public partial class RL_f5908efec95d364ebda8574126c5c10d : GenericRecordList<ST_73b5287c34f36a04fe003585368d6e1bStructure>, IEnumerable, IEnumerator {

protected override ST_73b5287c34f36a04fe003585368d6e1bStructure GetElementDefaultValue() {
return new ST_73b5287c34f36a04fe003585368d6e1bStructure();
}

public T[] ToArray<T>(Func<ST_73b5287c34f36a04fe003585368d6e1bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f5908efec95d364ebda8574126c5c10d recordList, Func<ST_73b5287c34f36a04fe003585368d6e1bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f5908efec95d364ebda8574126c5c10d(ST_73b5287c34f36a04fe003585368d6e1bStructure[] array) {
  RL_f5908efec95d364ebda8574126c5c10d result = new RL_f5908efec95d364ebda8574126c5c10d();
result.InnerFromArray(array);
    return result;
}

public static RL_f5908efec95d364ebda8574126c5c10d ToList<T>(T[] array, Func <T, ST_73b5287c34f36a04fe003585368d6e1bStructure> converter) {
  RL_f5908efec95d364ebda8574126c5c10d result = new RL_f5908efec95d364ebda8574126c5c10d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f5908efec95d364ebda8574126c5c10d FromRestList<T>(RestList<T> restList, Func <T, ST_73b5287c34f36a04fe003585368d6e1bStructure> converter) {
  RL_f5908efec95d364ebda8574126c5c10d result = new RL_f5908efec95d364ebda8574126c5c10d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f5908efec95d364ebda8574126c5c10d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_73b5287c34f36a04fe003585368d6e1bStructure> NewList() {
return new RL_f5908efec95d364ebda8574126c5c10d();
}


} // RL_f5908efec95d364ebda8574126c5c10d
}

